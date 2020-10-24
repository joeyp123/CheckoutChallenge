using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace CheckoutChallenge
{
    public class Scanner
    {
        public bool HasValue { get => _multiBuyDiscounts?.Any() ?? false; }

        List<StockKeepingUnit> _multiBuyDiscounts;

        public Scanner() { }

        public Scanner(string fileName)
        {
            try
            {
                _multiBuyDiscounts = new List<StockKeepingUnit>();

                var loadedSkuValues = FileHelper.ReadSKUValuesFromFile(fileName);

                LoadSkus(loadedSkuValues);

            }
            catch(Exception ex)
            {
                throw new Exception("There was an error loading the stock keeping units from the file." + ex.Message);
            }
        }

        public StockKeepingUnit ScanItem(string item)
        {
            if (HasValue)
            {
                if (_multiBuyDiscounts.Where(sku => sku.Item.ToLower() == item.ToLower()).Any())
                {
                    return _multiBuyDiscounts.Where(sku => sku.Item.ToLower() == item.ToLower()).FirstOrDefault();
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

        private void LoadSkus(List<string[]> loadedSkuValues)
        {
            try
            {
                var successfullyScannedSkus = new List<StockKeepingUnit>();

                foreach (var skuValues in loadedSkuValues)
                {
                    var scannedItem = ScanBarcode(skuValues[0], skuValues[1], skuValues[2], skuValues[3]);

                    if (scannedItem.HasValue())
                    {
                        successfullyScannedSkus.Add(scannedItem);
                    }
                    else
                    {
                        throw new Exception("Error scanning item.");
                    }
                }

                if (loadedSkuValues.Any())
                {
                    _multiBuyDiscounts.AddRange(successfullyScannedSkus);
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

        private StockKeepingUnit ScanBarcode(string item, string price, string specialQuantity, string specialPrice)
        {
            try
            {
                int parsedPrice;
                int? parsedSpecialQuantity = null;
                int? parsedSpecialPrice = null;

                if (Int32.TryParse(price, out var tempPriceVal))
                {
                    if(tempPriceVal > 0)
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

                if(!string.IsNullOrEmpty(specialQuantity))
                {
                    if (Int32.TryParse(specialQuantity, out var tempSpecialQuantityVal))
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
                
                if(!string.IsNullOrEmpty(specialPrice))
                {
                    if (Int32.TryParse(specialPrice, out var tempSpecialPriceVal))
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
