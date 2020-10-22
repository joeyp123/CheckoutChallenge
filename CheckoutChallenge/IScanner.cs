using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public interface IScanner
    {
        [Description("Attempts to scan the inputted values.")]
        StockKeepingUnit ScanBarcode(string item, string price, string specialQuantity, string specialPrice);
    }
}
