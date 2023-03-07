﻿using GildedRoseKata.Updaters;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var updater = UpdaterFactory.Create(item);
                updater.Update(item);
            }
        }
    }
}
