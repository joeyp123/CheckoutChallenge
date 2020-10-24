using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public class StockKeepingUnit
    {
        [DisplayName("Item")]
        public string Item { get; }

        [DisplayName("Price (£)")]
        public decimal Price { get; }

        [DisplayName("Special quantity")]
        public int? SpecialQuantity { get; }

        [DisplayName("Special price (£)")]
        public decimal? SpecialPrice { get; }

        public StockKeepingUnit(string item, int pricePence, int? specialQuantity, int? specialPricePence)
        {
            Item = item;
            Price = pricePence > 0 ? pricePence / 100m : 0m;
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPricePence / 100m;
        }

        public StockKeepingUnit(string item, decimal price, int? specialQuantity, decimal? specialPrice)
        {
            Item = item;
            Price = price > 0m ? price : 0m;
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPrice;
        }

        public bool HasValue()
        {
            return this.Item != null;
        }
    }
}
