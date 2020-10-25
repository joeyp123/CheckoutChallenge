using System;
using System.Collections.Generic;
using System.Linq;
using CheckoutChallenge;
using CheckoutChallenge.DataObjects;
using NUnit.Framework;

namespace CheckoutChallengeTests
{
    [TestFixture]
    public class TillTests
    {
        [Test]
        public void When_ScanItems_Expect_Correct_Till_Total()
        {
            int itemPricePenceA = 100;
            var skuA = new StockKeepingUnit("A", itemPricePenceA, null, null);

            int itemPricePenceB = 70;
            var skuB = new StockKeepingUnit("B", itemPricePenceB, null, null);

            var till = new Till();
            till.LoadMultiBuyDiscounts(new List<StockKeepingUnit> { skuA, skuB });
            till.TryScanItem("A",out var errorMessageA);
            till.TryScanItem("B",out var errorMessageB);

            var expectedTillTotal = itemPricePenceA + itemPricePenceB;
            var actualTillTotal = Convert.ToInt32(till.Total * 100);

            Assert.AreEqual(expectedTillTotal,actualTillTotal);
        }

        [Test]
        public void When_ScanItems_For_Multibuy_Expect_Correct_Till_Total()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;
            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.LoadMultiBuyDiscounts(new List<StockKeepingUnit> { sku });
            till.TryScanItem("A", out var errorMessage1);
            till.TryScanItem("A", out var errorMessage2);

            var expectedTillTotal = specialPricePence;
            var actualTillTotal = Convert.ToInt32(till.Total * 100);

            Assert.AreEqual(expectedTillTotal, actualTillTotal);
        }

        [Test]
        public void When_ScanItems_For_Multibuy_And_Normal_Expect_Correct_Till_Total()
        {
            int itemPricePenceA = 100;
            int specialQuantityA = 2;
            int specialPricePenceA = 150;
            var skuA = new StockKeepingUnit("A", itemPricePenceA, specialQuantityA, specialPricePenceA);

            int itemPricePenceB = 70;
            var skuB = new StockKeepingUnit("B", itemPricePenceB, null, null);

            var till = new Till();
            till.LoadMultiBuyDiscounts(new List<StockKeepingUnit> { skuA, skuB });
            till.TryScanItem("A", out var errorMessageA1);
            till.TryScanItem("A", out var errorMessageA2);
            till.TryScanItem("B", out var errorMessageB);

            var expectedTillTotal = specialPricePenceA + itemPricePenceB;
            var actualTillTotal = Convert.ToInt32(till.Total * 100);

            Assert.AreEqual(expectedTillTotal, actualTillTotal);
        }

        [Test]
        public void When_ScanItems_For_Several_Multibuy_Expect_Correct_Till_Total()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;
            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.LoadMultiBuyDiscounts(new List<StockKeepingUnit> { sku });
            till.TryScanItem("A", out var errorMessage1);
            till.TryScanItem("A", out var errorMessage2);
            till.TryScanItem("A", out var errorMessage3);

            var expectedTillTotal = specialPricePence + itemPricePence;
            var actualTillTotal = Convert.ToInt32(till.Total * 100);

            Assert.AreEqual(expectedTillTotal, actualTillTotal);
        }

        [Test]
        public void When_ScanItems_For_Multibuy_Expect_Correct_Till_DiscountTotal()
        {
            int itemPricePence = 100;
            int specialQuantity = 2;
            int specialPricePence = 150;
            var sku = new StockKeepingUnit("A", itemPricePence, specialQuantity, specialPricePence);

            var till = new Till();
            till.LoadMultiBuyDiscounts(new List<StockKeepingUnit> { sku });
            till.TryScanItem("A", out var errorMessage1);
            till.TryScanItem("A", out var errorMessage2);

            var expectedTillDiscountTotal = (2 * itemPricePence) - specialPricePence;
            var actualTillDiscountTotal = Convert.ToInt32(till.DiscountsTotal * 100);

            Assert.AreEqual(expectedTillDiscountTotal, actualTillDiscountTotal);
        }

        [Test]
        public void When_ScanItems_Expect_Added_To_Till_ScannedItems()
        {
            var skuA = new StockKeepingUnit("A", 100, null, null);
            var skuB = new StockKeepingUnit("B", 70, null, null);

            var till = new Till();
            var skus = new List<StockKeepingUnit> { skuA,skuB };
            till.LoadMultiBuyDiscounts(skus);

            till.TryScanItem("A",out var errorMessageA);
            till.TryScanItem("B", out var errorMessageB);

            Assert.IsTrue(skus.All(sku => till.ScannedItems.Contains(sku)));
        }
    }
}
