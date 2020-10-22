using System;
using System.Collections.Generic;
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
            Price = pricePence / 100m;
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPricePence / 100m;
        }

        public string Item { get; }
        public decimal Price { get; }
        public int? SpecialQuantity { get; }
        public decimal? SpecialPrice { get; }
    }
}
