using CheckoutChallenge;
using CheckoutChallenge.DataObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CheckoutChallengeTests
{
    [TestFixture]
    public class ScannerTests
    {
        [Test]
        public void When_ScanBarcode_For_Invalid_Price_Expect_Error_Thrown()
        {
            var scanner = new Scanner();

            string item = "A";
            string price = "A";

            var expectedException = new Exception("Error parsing item price.");

            Assert.Throws(Is.TypeOf(expectedException.GetType())
                           .And.Message.EqualTo(expectedException.Message),
                        delegate { scanner.ScanBarcode(item, price, string.Empty, string.Empty); });
        }

        [Test]
        public void When_ScanBarcode_For_Invalid_SpecialQuantity_Expect_Error_Thrown()
        {
            var scanner = new Scanner();

            string item = "A";
            string price = "100";
            string specialQuantity = "A";
            string specialPrice = "100";

            var expectedException = new Exception("Error parsing special quantity.");

            Assert.Throws(Is.TypeOf(expectedException.GetType())
                           .And.Message.EqualTo(expectedException.Message),
                        delegate { scanner.ScanBarcode(item, price, specialQuantity, specialPrice); });
        }

        [Test]
        public void When_ScanBarcode_For_Invalid_SpecialPrice_Expect_Error_Thrown()
        {
            var scanner = new Scanner();

            string item = "A";
            string price = "100";
            string specialQuantity = "100";
            string specialPrice = "A";

            var expectedException = new Exception("Error parsing special price.");

            Assert.Throws(Is.TypeOf(expectedException.GetType())
                           .And.Message.EqualTo(expectedException.Message),
                        delegate { scanner.ScanBarcode(item, price, specialQuantity, specialPrice); });
        }

        [Test]
        public void When_ScanBarcode_For_Negative_Price_Expect_Error_Thrown()
        {
            var scanner = new Scanner();

            string item = "A";
            string price = "-100";

            var expectedException = new Exception("Item price should be greater than zero.");

            Assert.Throws(Is.TypeOf(expectedException.GetType())
                           .And.Message.EqualTo(expectedException.Message),
                        delegate { scanner.ScanBarcode(item, price, string.Empty, string.Empty); });
        }

        [Test]
        public void When_ScanItem_For_ValidSkus_Expect_Skus_Returned()
        {
            var scanner = new Scanner();

            var itemA = "A";
            var itemB = "B";

            var skuA = new StockKeepingUnit(itemA, 100, null, null);
            var skuB = new StockKeepingUnit(itemB, 70, null, null);

            var skus = new List<StockKeepingUnit> { skuA, skuB };

            scanner.LoadSkus(skus);

            Assert.That(scanner.ScanItem(itemA) == skuA && scanner.ScanItem(itemB) == skuB);
        }
    }
}
