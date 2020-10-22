using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutChallenge
{
    public class Scanner : IScanner
    {
        public StockKeepingUnit ScanBarcode(string item, string price, string specialQuantity, string specialPrice)
        {
            try
            {
                return new StockKeepingUnit(item, Convert.ToDecimal(price), Convert.ToInt32(specialQuantity), Convert.ToDecimal(specialPrice));
            }
            catch
            {
                return null;
            }
        }
    }
}
