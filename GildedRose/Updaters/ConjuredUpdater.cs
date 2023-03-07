namespace GildedRoseKata.Updaters
{
    public class ConjuredUpdater : IUpdater
    {
        public void Update(Item item)
        {
            item.SellIn--;

            int qualityDecay = item.SellIn >= 0 ? 2 : 4;

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
