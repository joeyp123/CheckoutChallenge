using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutChallenge
{
    public static class Scanner
    {
        public static StockKeepingUnit ScanBarcode(string item, string price, string specialQuantity, string specialPrice)
        {
            try
            {
                //TODO - if invalid data is entered in the two nullable fields then don't just let the item be scanned
                //prevents an item being scanned with only part of its data

                int? parsedSpecialQuantity = Int32.TryParse(specialQuantity, out var tempSpecialQuantityVal) ? tempSpecialQuantityVal : (int?)null;
                decimal? parsedSpecialPrice = decimal.TryParse(specialPrice, out var tempSpecialPriceVal) ? tempSpecialPriceVal : (decimal?)null;

                return new StockKeepingUnit(item, Convert.ToDecimal(price), parsedSpecialQuantity, parsedSpecialPrice);
            }
            catch
            {
                throw new Exception("Error scanning barcode details.");
            }
        }
    }
}
