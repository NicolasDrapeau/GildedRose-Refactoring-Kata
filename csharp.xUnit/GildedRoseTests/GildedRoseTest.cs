using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new ("foo", 0, 0 ) };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Assert.Equal("fixme", Items[0].Name);
    }
}