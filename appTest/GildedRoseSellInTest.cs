using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using app;

namespace appTest
{
    [TestClass]
    public class GildedRoseSellInTest
    {
        [TestMethod]
        public void DecrementNormalItemSellIn()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "item", SellIn = 10, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9, Items[0].SellIn);
        }

        [TestMethod]
        public void DecrementNormalItemPassesSellIn()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "item", SellIn = 0, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [TestMethod]
        public void DecrementSulfurasSellIn()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Sulfuras item", SellIn = 5, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(5, Items[0].SellIn);
        }

        [TestMethod]
        public void DecrementSulfurasPassesSellIn()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Sulfuras item", SellIn = 0, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].SellIn);
        }

        [TestMethod]
        public void DecrementSulfurasNegativeSellIn()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Sulfuras item", SellIn = -5, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-5, Items[0].SellIn);
        }
    }
}
