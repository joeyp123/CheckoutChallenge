using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public class Till : ITill
    {
        public decimal Total { get; }

        public bool ScanItem(string item, string price, string specialQuantity, string specialPrice)
        {
            throw new NotImplementedException();
        }
    }
}
