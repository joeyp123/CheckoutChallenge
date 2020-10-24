using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
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
            decimal? itemTotal = 0.0m;

            if (SpecialQuantity.HasValue && SpecialPrice.HasValue)
            {
                //apply multibuy discount
                itemTotal += ((QuantityPurchased - (QuantityPurchased % SpecialQuantity)) / SpecialQuantity) * SpecialPrice;

                //apply normal price for any left over
                itemTotal += (QuantityPurchased % SpecialQuantity) * NormalPrice;
            }
            else
            {
                itemTotal = QuantityPurchased * NormalPrice;
            }

            return itemTotal.GetValueOrDefault(0.0m);
        }
    }
}
