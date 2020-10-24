using System;
using System.Collections.Generic;
using CheckoutChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutChallengeTests
{
    [TestClass]
    public class TillTests
    {
        [TestMethod]
        public void When_ScanItems_Expect_Correct_Till_Total()
        {
            int itemPricePence = 100;

            var till = new Till();
            var skus = new List<StockKeepingUnit> { new StockKeepingUnit("A", itemPricePence, null, null) };

            till.ScanItems(skus);

            Assert.AreEqual(Convert.ToInt32(till.Total * 100), itemPricePence);
        }

        [TestMethod]
        public void When_ScanItems_For_Multibuy_Expect_Correct_Till_Total()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;

            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.ScanItems(new List<StockKeepingUnit> { sku,sku});

            Assert.AreEqual(Convert.ToInt32(till.Total * 100), specialPricePence);
        }

        [TestMethod]
        public void When_ScanItems_For_Multibuy_And_Normal_Expect_Correct_Till_Total()
        {
            int itemPricePenceA = 100;
            int specialQuantityA = 2;
            int specialPricePenceA = 150;
            var skuA = new StockKeepingUnit("A", itemPricePenceA, specialQuantityA, specialPricePenceA);
            
            int itemPricePenceB = 70;
            var skuB = new StockKeepingUnit("B", itemPricePenceB, null,null);

            var till = new Till();
            till.ScanItems(new List<StockKeepingUnit> { skuA, skuA, skuB });

            Assert.AreEqual(Convert.ToInt32(till.Total * 100), specialPricePenceA + itemPricePenceB);
        }

        [TestMethod]
        public void When_ScanItems_For_Several_Multibuy_Expect_Correct_Till_Total()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;

            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.ScanItems(new List<StockKeepingUnit> { sku, sku, sku });

            Assert.AreEqual(Convert.ToInt32(till.Total * 100), specialPricePence + itemPricePence);
        }

        [TestMethod]
        public void When_ScanItems_For_Multibuy_Expect_Correct_Till_DiscountTotal()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;

            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.ScanItems(new List<StockKeepingUnit> { sku, sku });

            Assert.AreEqual(Convert.ToInt32(till.DiscountsTotal * 100), (2 * itemPricePence) - specialPricePence);
        }
    }
}
