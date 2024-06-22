using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            new Item { Name = Name.Dexterity, SellIn = 10, Quality = 20 },
            new Item { Name = Name.AgedBrie, SellIn = 2, Quality = 0 },
            new Item { Name = Name.Elixir, SellIn = 5, Quality = 7 },
            new Item { Name = Name.Sulfuras, SellIn = 0, Quality = 80 },
            new Item { Name = Name.Sulfuras, SellIn = -1, Quality = 80 },
            new Item { Name = Name.Backstage, SellIn = 15, Quality = 20 },
            new Item { Name = Name.Backstage, SellIn = 10, Quality = 49 },
            new Item { Name = Name.Backstage, SellIn = 5, Quality = 49 },
            // this conjured item does not work properly yet
            new Item { Name = Name.Conjured, SellIn = 3, Quality = 6 }
        };

        var app = new GildedRose(items);

        var days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var t in items)
            {
                Console.WriteLine(t.Name + ", " + t.SellIn + ", " + t.Quality);
            }

            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}