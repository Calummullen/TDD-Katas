using System;
using System.Collections.Generic;
using System.Text;
using KataSolutions.GildedRose;
using NUnit.Framework;

namespace KataTests
{
    public class GildedRoseTests
    {
        [TestFixture]
        public class GildedRoseTest
        {
            [Test]
            public void foo()
            {
                IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
                var app = new GildedRose(items);
                app.UpdateQuality();
                Assert.AreEqual("fixme", items[0].Name);
            }
        }
    }
}
