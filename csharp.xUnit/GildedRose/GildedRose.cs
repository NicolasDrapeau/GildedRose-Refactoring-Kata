using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var t in Items)
        {
            t.IncrementQuality(() => t.Name == GildName.AgedBrie);

            if (t.Name == GildName.Backstage)
            {
                t.IncrementQuality();
                t.IncrementQuality(() => t.SellIn < 11);
                t.IncrementQuality(() => t.SellIn < 6);
            }

            t.DecrementQuality();


            if (t.DecrementSellIn() >= 0)
            {
                continue;
            }

            t.IncrementQuality(() => t.Name == GildName.AgedBrie);
            t.InitalizeQuality();
            t.DecrementQuality();
        }
    }
}