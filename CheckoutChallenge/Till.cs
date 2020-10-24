using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutChallenge
{
    public class Till : ITill
    {
        public decimal Total { get => RecalculatePrice(); }
        public List<StockKeepingUnit> ScannedItems { get; }

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

            var groupedItems = ScannedItems
                                    .GroupBy(sku => new { sku.Item, sku.Price, sku.SpecialQuantity, sku.SpecialPrice })
                                    .Select(sku => new
                                    {
                                        StockKeepingUnit = sku.Key,
                                        Count = sku.Count()
                                    });

            var itemQuantities = groupedItems.ToDictionary(sku => sku.StockKeepingUnit, sku => sku.Count);

            foreach (var item in itemQuantities)
            {
                var sku = item.Key;
                var quantity = item.Value;

                if (sku.SpecialQuantity.HasValue && sku.SpecialPrice.HasValue)
                {
                    decimal? itemTotal = 0.0m;

                    //apply multibuy discount
                    itemTotal += ((quantity - (quantity % sku.SpecialQuantity)) / sku.SpecialQuantity) * sku.SpecialPrice;

                    //apply normal price for any left over
                    itemTotal += (quantity % sku.SpecialQuantity) * sku.Price;

                    basketTotal += itemTotal.GetValueOrDefault(0.0m);
                }
                else
                {
                    basketTotal += sku.Price * quantity;
                }
            }

            return basketTotal;
        }

    }
}
