using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Theory]
        [InlineData("Elixir of the Mongoose", 5, 20, 4, 19)]    
        [InlineData("Elixir of the Mongoose", 0, 20, -1, 18)]   // sellIn negative, quality -2
        [InlineData("Elixir of the Mongoose", 0, 0, -1, 0)]     // quality goes no lower than 0
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 80, 0, 80)]
        [InlineData("Aged Brie", 5, 40, 4, 41)]     // quality increases
        [InlineData("Aged Brie", 0, 40, -1, 42)]    // quality increases by 2
        [InlineData("Aged Brie", 0, 50, -1, 50)]    // quality never goes above 50
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 20, 14, 21)]       // over 10 days +1
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 8, 20, 7, 22)]         // 6-10 days +2
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 3, 20, 2, 23)]         // 0-5 days +3
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 0, 20, -1, 0)]         // concert passed
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 3, 49, 2, 50)]         // never goes above 50
        [InlineData("Conjured bisquit", 5, 30, 4, 28)]          // quality decreases by 2
        [InlineData("Conjured bisquit", 0, 30, -1, 26)]         // if sellin negative, quality decreases by 4
        [InlineData("Conjured bisquit", 0, 1, -1, 0)]           // quality decreases no lower than 0
        public void UpdateQuality_updates_as_expected(string item, int sellin, int quality, int expectedSellin, int expectedQuality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = item, SellIn = sellin, Quality = quality } };
            GildedRose app = new(Items);
            app.UpdateQuality();
            var updatedItem = Items[0];
            Assert.Equal(item, updatedItem.Name);
            Assert.Equal(expectedSellin, updatedItem.SellIn);
            Assert.Equal(expectedQuality, updatedItem.Quality);
        }
    }
}
