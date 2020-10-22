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
            Price = pricePence / 100m; //TODO - handle = 0 (accept it but don't try and convert)
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPricePence / 100m; //TODO - handle = 0 (don't accept it unless price is also 0)

            //TODO - none should be negative
        }

        public string Item { get; }
        public decimal Price { get; }
        public int? SpecialQuantity { get; }
        public decimal? SpecialPrice { get; }
    }
}
