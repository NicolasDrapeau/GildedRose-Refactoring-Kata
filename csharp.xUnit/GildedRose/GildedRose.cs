using System.Collections.Generic;

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
            if (t.Name != Name.AgedBrie && t.Name != Name.Backstage)
            {
                if (t.Quality > 0)
                {
                    if (t.Name != Name.Sulfuras)
                    {
                        t.Quality--;
                    }
                }
            }
            else
            {
                if (t.Quality < 50)
                {
                    t.Quality = t.Quality + 1;

                    if (t.Name == Name.Backstage)
                    {
                        if (t.SellIn < 11)
                        {
                            if (t.Quality < 50)
                            {
                                t.Quality = t.Quality + 1;
                            }
                        }

                        if (t.SellIn < 6)
                        {
                            if (t.Quality < 50)
                            {
                                t.Quality = t.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (t.Name != Name.Sulfuras)
            {
                t.SellIn = t.SellIn - 1;
            }

            if (t.SellIn < 0)
            {
                if (t.Name != Name.AgedBrie)
                {
                    if (t.Name != Name.Backstage)
                    {
                        if (t.Quality > 0 && t.Name != Name.Sulfuras)
                        {
                            t.Quality = t.Quality - 1;
                        }
                    }
                    else
                    {
                        t.Quality = t.Quality - t.Quality;
                    }
                }
                else
                {
                    if (t.Quality < 50)
                    {
                        t.Quality ++;
                    }
                }
            }
        }
    }
}