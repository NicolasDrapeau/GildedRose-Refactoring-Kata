using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items =
        [
            new (GildName.Dexterity, 10, 20),
            new (GildName.AgedBrie, 2,  0 ),
            new (GildName.Elixir, 5, 7 ),
            new (GildName.Sulfuras,  0, 80 ),
            new (GildName.Sulfuras, -1,  80 ),
            new (GildName.Backstage, 15, 20 ),
            new (GildName.Backstage, 10, 49 ),
            new (GildName.Backstage, 5, 49 ),
            // this conjured item does not work properly yet
            new (GildName.Conjured, 3, 6 )
        ];

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