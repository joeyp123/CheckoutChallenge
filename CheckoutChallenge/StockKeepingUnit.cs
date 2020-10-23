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
        public StockKeepingUnit(string item, decimal pricePence, int? specialQuantity, decimal? specialPricePence)
        {
            Item = item;
            Price = pricePence > 0m ? pricePence / 100m : 0m;
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPricePence / 100m;
        }

        [DisplayName("Item")]
        public string Item { get; }

        [DisplayName("Price (£)")]
        public decimal Price { get; }

        [DisplayName("Special quantity")]
        public int? SpecialQuantity { get; }

        [DisplayName("Special price (£)")]
        public decimal? SpecialPrice { get; }

        public bool HasValue()
        {
            return this.Item != null;
        }
    }
}
