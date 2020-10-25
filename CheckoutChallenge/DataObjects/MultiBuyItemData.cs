using System.ComponentModel;

namespace CheckoutChallenge.DataObjects
{
    public class MultiBuyItemData
    {
        [DisplayName("Item")]
        public string Item { get => _sku.Item; }

        [DisplayName("Normal price (£)")]
        public decimal NormalPrice { get => _sku.Price; }

        [DisplayName("Special quantity")]
        public int? SpecialQuantity { get => _sku.SpecialQuantity; }

        [DisplayName("Special price (£)")]
        public decimal? SpecialPrice { get => _sku.SpecialPrice; }

        [DisplayName("Quantity purchased")]
        public int QuantityPurchased { get; }

        [DisplayName("Total (£)")]
        public decimal ItemTotal { get => GetItemTotal(); }

        private StockKeepingUnit _sku;

        public MultiBuyItemData(StockKeepingUnit sku, int quantityPurchased)
        {
            _sku = sku;
            QuantityPurchased = quantityPurchased;
        }

        public bool HasDiscountApplied()
        {
            return _sku.SpecialQuantity.HasValue && _sku.SpecialPrice.HasValue && QuantityPurchased >= SpecialQuantity;
        }

        private decimal GetItemTotal()
        {
            decimal itemTotal = 0.0m;

            if (SpecialQuantity.HasValue && SpecialPrice.HasValue)
            {
                itemTotal += GetTotalPriceForMultiBuyMultiples(QuantityPurchased, SpecialQuantity.Value, SpecialPrice.Value);

                itemTotal += GetTotalPriceForRemainingNonMultiBuyItems(QuantityPurchased, SpecialQuantity.Value, NormalPrice);
            }
            else
            {
                itemTotal = QuantityPurchased * NormalPrice;
            }

            return itemTotal;
        }

        private decimal GetTotalPriceForMultiBuyMultiples(int quantityPurchased, int specialQuantity, decimal specialPrice)
        {
            return ((quantityPurchased - (quantityPurchased % specialQuantity)) / specialQuantity) * specialPrice;
        }

        private decimal GetTotalPriceForRemainingNonMultiBuyItems(int quantityPurchased, int specialQuantity, decimal normalPrice)
        {
            return (quantityPurchased % specialQuantity) * normalPrice;
        }
    }
}
