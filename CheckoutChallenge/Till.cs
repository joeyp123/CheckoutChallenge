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

        public bool ScanItem(string item, out string errorMessage)
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

        public void ScanItems(List<StockKeepingUnit> skus)
        {
            foreach (var sku in skus)
            {
                ScannedItems.Add(sku);
            }
        }

        public bool LoadMultiBuyDiscountsFromFile(string fileName, out string errorMessage)
        {
            try
            {
                errorMessage = string.Empty;

                Scanner = new Scanner(fileName);

                return true;
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
