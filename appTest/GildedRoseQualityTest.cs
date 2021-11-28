using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using app;

namespace appTest
{
    [TestClass]
    public class GildedRoseQualityTest
    {
        [TestMethod]
        public void NormalItemQualityDecreasesBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "item", SellIn = 10, Quality = 5 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(4, Items[0].Quality);
        }

        [TestMethod]
        public void NormalItemQualityDecreasesTwiceAfterDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "item", SellIn = 0, Quality = 10 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }

        [TestMethod]
        public void NormalItemQualityNotDecreasesAfterLowerBound()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "item", SellIn = 10, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void ConjuredQualityDecreasesBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Conjured item", SellIn = 10, Quality = 5 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }

        [TestMethod]
        public void ConjuredQualityDecreasesTwiceAfterDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Conjured item", SellIn = 0, Quality = 10 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(6, Items[0].Quality);
        }

        [TestMethod]
        public void SulfurasQualityNotChangesBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Sulfuras item", SellIn = 10, Quality = 80 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }

        [TestMethod]
        public void SulfurasQualityNotChangesAfterDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Sulfuras item", SellIn = 0, Quality = 80 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }

        [TestMethod]
        public void AgedBrieQualityIncreasesBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Aged Brie item", SellIn = 10, Quality = 0 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(1, Items[0].Quality);
        }

        [TestMethod]
        public void AgedBrieQualityIncreasesTwiceAfterDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Aged Brie item", SellIn = 0, Quality = 10 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(12, Items[0].Quality);
        }

        [TestMethod]
        public void AgedBrieQualityNotIncreasesAfterUpperBound()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Aged Brie item", SellIn = 10, Quality = 50 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePassesQualityDropsToZeroAfterDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Backstage passes item", SellIn = 0, Quality = 20 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePassesQualityIncreasesWithinFiveDaysBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Backstage passes item", SellIn = 4, Quality = 20 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePassesQualityIncreasesWithinTenDaysBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Backstage passes item", SellIn = 9, Quality = 20 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(22, Items[0].Quality);
        }

        [TestMethod]
        public void BackstagePassesQualityIncreasesBeforeTenDaysBeforeDue()
        {
            IList<app.Item> Items = new List<app.Item> { new Item { Name = "Backstage passes item", SellIn = 11, Quality = 20 } };
            app.GildedRose app = new app.GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(21, Items[0].Quality);
        }
    }
}
