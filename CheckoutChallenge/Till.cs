﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public class Till : ITill
    {
        public decimal Total { get => ScannedItems.Sum(sku => sku.Price); }
        public List<StockKeepingUnit> ScannedItems { get; }

        public Till()
        {
            ScannedItems = new List<StockKeepingUnit>();
        }

        public bool ScanItem(string item, string price, string specialQuantity, string specialPrice)
        {
            try
            {
                var scannedItem = Scanner.ScanBarcode(item, price, specialQuantity, specialPrice);

                if (scannedItem.HasValue())
                {
                    ScannedItems.Add(scannedItem);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ScanItem(StockKeepingUnit sku)
        {
            ScannedItems.Add(sku);

            return true;
        }
    }
}
