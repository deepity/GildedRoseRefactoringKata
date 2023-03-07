namespace GildedRoseKata.Updaters
{
    public class StandardUpdater : IUpdater
    {
        public void Update(Item item)
        {
            item.SellIn--;

            int qualityDecay = item.SellIn >= 0 ? 1 : 2;

            if (item.Quality >= qualityDecay)
            {
                item.Quality -= qualityDecay;
            }
            else
            {
                item.Quality = 0;
            }
        }
    }
}
