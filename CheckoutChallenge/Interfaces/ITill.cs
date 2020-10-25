using CheckoutChallenge.DataObjects;
using System.Collections.Generic;

namespace CheckoutChallenge.Interfaces
{
    public interface ITill
    {
        decimal Total { get; }
        decimal DiscountsTotal { get; }
        List<StockKeepingUnit> ScannedItems { get; }
        List<MultiBuyItemData> DiscountsApplied { get; }
        bool TryScanItem(string item, out string errorMessage);
        bool LoadMultiBuyDiscountsFromFile(string fileName, out string errorMessage);
        Scanner Scanner { get; }
    }
}
