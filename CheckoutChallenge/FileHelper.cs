using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CheckoutChallenge
{
    public static class FileHelper
    {
        internal static List<StockKeepingUnit> ReadSKUsFromFile(string fileName)
        {
            var skus = new List<StockKeepingUnit>();

            var lines = File.ReadAllLines(fileName).Select(a => a.Split(';'));
            
            foreach(var line in lines)
            {

            }

            return skus;
        }
    }
}
