using System;
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

        bool ScanItem(string item, string price, string specialQuantity, string specialPrice, out string errorMessage);
        void ScanItems(List<StockKeepingUnit> sku);
        bool ScanItemsFromFile(string fileName, out string errorMessage);
    }
}
