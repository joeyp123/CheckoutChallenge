using CheckoutChallenge.DataObjects;
using CheckoutChallenge.Interfaces;
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

        public Scanner Scanner { get; private set; }

        public Till()
        {
            ScannedItems = new List<StockKeepingUnit>();
            Scanner = new Scanner();
        }

        public bool TryScanItem(string item, out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;

                var scannedItem = Scanner.ScanItem(item);

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

        public bool LoadMultiBuyDiscountsFromFile(string fileName, out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;

                var skuLoadResult = Scanner.LoadSkusFromFile(fileName);

                if(!skuLoadResult)
                {
                    errorMessage = "There was an error parsing one or more stock keeping units from the file. Any successfully parsed units have been loaded.";
                }

                return skuLoadResult;
            }
            catch (Exception ex)
            {
                errorMessage = "There was an error loading the stock keeping units from the file. " + ex.Message;
                return false;
            }
        }

        public void LoadMultiBuyDiscounts(List<StockKeepingUnit> skus)
        {
            Scanner.LoadSkus(skus);
        }

        private decimal RecalculatePrice()
        {
            decimal basketTotal = 0.0m;

            foreach (var item in GetItemQuantities())
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

            foreach(var item in GetItemQuantities())
            {
                var multiBuyItem = new MultiBuyItemData(item.Key, item.Value);

                if (multiBuyItem.HasDiscountApplied()) { multiBuyItems.Add(multiBuyItem); }
            }

            return multiBuyItems;
        }

        private Dictionary<StockKeepingUnit, int> GetItemQuantities()
        {
            return ScannedItems
                .GroupBy(sku => sku)
                .Select(sku => new
                {
                    StockKeepingUnit = new StockKeepingUnit(sku.Key.Item, sku.Key.Price, sku.Key.SpecialQuantity, sku.Key.SpecialPrice),
                    Count = sku.Count()
                })
                .ToDictionary(sku => sku.StockKeepingUnit, sku => sku.Count);
        }
    }
}
