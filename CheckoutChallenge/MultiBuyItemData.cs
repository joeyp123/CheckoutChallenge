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

        private decimal GetItemTotal()
        {
            decimal? itemTotal = 0.0m;

            if (_sku.SpecialQuantity.HasValue && _sku.SpecialPrice.HasValue)
            {
                //apply multibuy discount
                itemTotal += ((QuantityPurchased - (QuantityPurchased % _sku.SpecialQuantity)) / _sku.SpecialQuantity) * _sku.SpecialPrice;

                //apply normal price for any left over
                itemTotal += (QuantityPurchased % _sku.SpecialQuantity) * _sku.Price;
            }
            else
            {
                itemTotal = _sku.Price * QuantityPurchased;
            }

            return itemTotal.GetValueOrDefault(0.0m);
        }
    }
}
