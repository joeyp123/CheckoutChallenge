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
        List<StockKeepingUnit> ScannedItems { get; }

        bool ScanItem(string item, string price, string specialQuantity, string specialPrice);
        bool ScanItem(StockKeepingUnit sku);
    }
}