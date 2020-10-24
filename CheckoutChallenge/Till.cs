using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutChallenge
{
    public class Till : ITill
    {
        public decimal Total { get => RecalculatePrice(); }
        public decimal DiscountsTotal { get => (ScannedItems.Sum(sku => sku.Price) - Total);}
        public List<StockKeepingUnit> ScannedItems { get; }
        public List<MultiBuyItemData> DiscountsApplied { get => GetAppliedDiscounts(ScannedItems); }

        public Till()
        {
            ScannedItems = new List<StockKeepingUnit>();
        }

        public bool ScanItem(string item, string price, string specialQuantity, string specialPrice, out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;

                var scannedItem = Scanner.ScanBarcode(item, price, specialQuantity, specialPrice);

                if (scannedItem.HasValue())
                {
                    ScannedItems.Add(scannedItem);

                    return true;
                }
                else
                {
                    errorMessage = "Error scanning item.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public void ScanItems(List<StockKeepingUnit> skus)
        {
            foreach (var sku in skus)
            {
                ScannedItems.Add(sku);
            }
        }

        public bool ScanItemsFromFile(string fileName, out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;
                var successfullyScannedItems = new List<StockKeepingUnit>();

                var loadedSKUValues = FileHelper.ReadSKUValuesFromFile(fileName);

                foreach (var skuValues in loadedSKUValues)
                {
                    var scannedItem = Scanner.ScanBarcode(skuValues[0], skuValues[1], skuValues[2], skuValues[3]);

                    if (scannedItem.HasValue())
                    {
                        successfullyScannedItems.Add(scannedItem);
                    }
                    else
                    {
                        errorMessage = "Error scanning item.";
                    }
                }

                if (string.IsNullOrEmpty(errorMessage))
                {
                    ScanItems(successfullyScannedItems);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private decimal RecalculatePrice()
        {
            decimal basketTotal = 0.0m;

            foreach (var item in ItemQuantities())
            {
                var sku = item.Key;
                var quantity = item.Value;

                var multiBuyData = new MultiBuyItemData(sku, quantity);

                basketTotal += multiBuyData.ItemTotal;
            }

            return basketTotal;
        }

        private List<MultiBuyItemData> GetAppliedDiscounts(List<StockKeepingUnit> scannedItems)
        {
            var multiBuyItems = new List<MultiBuyItemData>();

            foreach(var item in ItemQuantities())
            {
                var multiBuyItem = new MultiBuyItemData(item.Key, item.Value);

                if (multiBuyItem.HasDiscountApplied()) { multiBuyItems.Add(multiBuyItem); }
            }

            return multiBuyItems;
        }

        private Dictionary<StockKeepingUnit, int> ItemQuantities()
        {
            var groupedItems = ScannedItems
                                    .GroupBy(sku => new { sku.Item, sku.Price, sku.SpecialQuantity, sku.SpecialPrice })
                                    .Select(sku => new
                                    {
                                        StockKeepingUnit = sku.Key,
                                        Count = sku.Count()
                                    });

            var groupedQuantities = groupedItems.ToDictionary(sku => sku.StockKeepingUnit, sku => sku.Count);

            var itemQuantities = new Dictionary<StockKeepingUnit, int>();

            foreach (var item in groupedQuantities)
            {
                itemQuantities.Add(new StockKeepingUnit(item.Key.Item, item.Key.Price, item.Key.SpecialQuantity, item.Key.SpecialPrice), item.Value);
            }

            return itemQuantities;
        }

    }
}
