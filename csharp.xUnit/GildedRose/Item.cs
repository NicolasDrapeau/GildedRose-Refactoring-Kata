using System;
using System.Collections.ObjectModel;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; private set; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public void IncrementQuality(Func<bool> condition)
    {
        if (Quality < 50 && condition())
        {
            Quality++;
        }

    }

    public void IncrementQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }
    }

    public void DecrementQuality()
    {
        Collection<string> names = [GildName.Elixir, GildName.Conjured, GildName.Dexterity];
        if (Quality > 0 && names.Contains(Name))
        {
            Quality--;
        }
    }

    internal void InitalizeQuality()
    {
        if (Name == GildName.Backstage)
        {
            Quality = 0;
        }
    }

    internal int DecrementSellIn()
        => Name != GildName.Sulfuras
        ? --SellIn
        : SellIn;
}



public static class GildName
{
    public static readonly string AgedBrie = "Aged Brie";
    public static readonly string Backstage = "Backstage passes to a TAFKAL80ETC concert";
    public static readonly string Sulfuras = "Sulfuras, Hand of Ragnaros";
    public static readonly string Dexterity = "+5 Dexterity Vest";
    public static readonly string Elixir = "Elixir of the Mongoose";
    public static readonly string Conjured = "Conjured Mana Cake";

}
