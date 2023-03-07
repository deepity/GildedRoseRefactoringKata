namespace GildedRoseKata.Updaters
{
    public class AgedBrieUpdater : IUpdater
    {
        public void Update(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }

            if (item.Quality > 50)
                item.Quality = 50;
        }

    }
}
