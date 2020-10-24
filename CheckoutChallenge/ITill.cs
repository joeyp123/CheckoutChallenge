﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public interface ITill
    {
        decimal Total { get; }
        decimal DiscountsTotal { get; }
        List<StockKeepingUnit> ScannedItems { get; }
        List<MultiBuyItemData> DiscountsApplied { get; }
        bool ScanItem(string item, out string errorMessage);
        void ScanItems(List<StockKeepingUnit> sku);
        bool LoadMultiBuyDiscountsFromFile(string fileName, out string errorMessage);
        Scanner Scanner { get; }
    }
}
