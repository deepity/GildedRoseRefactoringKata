namespace GildedRoseKata.Updaters
{
    class UpdaterFactory
    {
        public static IUpdater Create(Item item)
        {
            if (item.Name.StartsWith("Sulfuras"))
            {
                return new SulfurasUpdater();
            }
            else if (item.Name.Equals("Aged Brie"))
            {
                return new AgedBrieUpdater();
            }
            else if (item.Name.StartsWith("Backstage pass"))
            {
                return new BackstagePassesUpdater();
            }
            else if (item.Name.StartsWith("Conjured"))
            {
                return new ConjuredUpdater();
            }
            else
            {
                return new StandardUpdater();
            }
        }
    }
}
