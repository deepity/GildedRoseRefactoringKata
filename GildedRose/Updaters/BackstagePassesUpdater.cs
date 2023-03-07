namespace GildedRoseKata.Updaters
{
    public class BackstagePassesUpdater : IUpdater
    {
        public void Update(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)  // 0 .. 5
            {
                item.Quality += 3;
            }
            else if (item.SellIn <= 10) // 6 .. 10
            {
                item.Quality += 2;
            }
            else                       // > 10
            {
                item.Quality += 1;
            }

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
