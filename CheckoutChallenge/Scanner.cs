using CheckoutChallenge.DataObjects;
using CheckoutChallenge.Extensions;
using CheckoutChallenge.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutChallenge
{
    public class Scanner
    {
        public bool SkusLoaded { get => EnumerableExtensions.NullSafeAny(_multiBuyDiscounts); }

        List<StockKeepingUnit> _multiBuyDiscounts;

        public Scanner() { }

        public bool LoadSkusFromFile(string fileName)
        {
            _multiBuyDiscounts = new List<StockKeepingUnit>();

            var loadedSkuValues = FileHelper.ReadSKUValuesFromFile(fileName);

            return LoadSkus(loadedSkuValues);
        }

        public StockKeepingUnit ScanItem(string item)
        {
            if (SkusLoaded)
            {
                if (_multiBuyDiscounts.Any(sku => sku.Item.Equals(item, StringComparison.OrdinalIgnoreCase)))
                {
                    return _multiBuyDiscounts.FirstOrDefault(sku => sku.Item.Equals(item, StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    throw new Exception("Could not find stock keeping unit for that item.");
                }
            }
            else
            {
                throw new Exception("Load stock keeping units before scanning items.");
            }
        }

        public void LoadSkus(List<StockKeepingUnit> skusToLoad)
        {
            _multiBuyDiscounts = new List<StockKeepingUnit>();

            _multiBuyDiscounts.AddRange(skusToLoad);
        }

        private bool LoadSkus(List<string[]> loadedSkuValues)
        {
            try
            {
                var successfullyScannedSkus = new List<StockKeepingUnit>();
                bool allSkusLoadedSuccessfully = true;

                foreach (var skuValues in loadedSkuValues)
                {
                    try
                    {
                        var scannedItem = ScanBarcode(skuValues[0], skuValues[1], skuValues[2], skuValues[3]);

                        if (scannedItem.HasValue())
                        {
                            successfullyScannedSkus.Add(scannedItem);
                        }
                        else
                        {
                            allSkusLoadedSuccessfully = false;
                        }
                    }
                    catch
                    {
                        allSkusLoadedSuccessfully = false;
                    }
                }

                if (successfullyScannedSkus.Any())
                {
                    LoadSkus(successfullyScannedSkus);

                    return allSkusLoadedSuccessfully;
                }
                else
                {
                    throw new Exception("Could not parse any stock keeping units.");
                }
            }
            catch
            {
                throw new Exception("Error scanning stock keeping units from file.");
            }
        }

        public StockKeepingUnit ScanBarcode(string item, string price, string specialQuantity, string specialPrice)
        {
            int parsedPrice;
            int? parsedSpecialQuantity = null;
            int? parsedSpecialPrice = null;

            if(string.IsNullOrEmpty(item))
            {
                throw new Exception("Item name cannot be empty.");
            }

            if (int.TryParse(price, out var tempPriceVal))
            {
                if (tempPriceVal > 0)
                {
                    parsedPrice = tempPriceVal;
                }
                else
                {
                    throw new Exception("Item price should be greater than zero.");
                }
            }
            else
            {
                throw new Exception("Error parsing item price.");
            }

            if (!string.IsNullOrEmpty(specialQuantity))
            {
                if (int.TryParse(specialQuantity, out var tempSpecialQuantityVal))
                {
                    if (tempSpecialQuantityVal > 0)
                    {
                        parsedSpecialQuantity = tempSpecialQuantityVal;
                    }
                    else
                    {
                        throw new Exception("Special quantity should be greater than zero.");
                    }
                }
                else
                {
                    throw new Exception("Error parsing special quantity.");
                }
            }

            if (!string.IsNullOrEmpty(specialPrice))
            {
                if (int.TryParse(specialPrice, out var tempSpecialPriceVal))
                {
                    if (tempSpecialPriceVal > 0)
                    {
                        parsedSpecialPrice = tempSpecialPriceVal;
                    }
                    else
                    {
                        throw new Exception("Special price should be greater than zero.");
                    }
                }
                else
                {
                    throw new Exception("Error parsing special price.");
                }
            }

            return new StockKeepingUnit(item, parsedPrice, parsedSpecialQuantity, parsedSpecialPrice);
        }
    }
}
