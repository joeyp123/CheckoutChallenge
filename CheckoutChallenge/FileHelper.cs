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

            var lines = File.ReadAllLines(fileName).Skip(1);

            foreach (var line in lines)
            {
                var lineArray = line.Split(',');

                var sku = Scanner.ScanBarcode(lineArray[0], lineArray[1], lineArray[2], lineArray[3]);

                if (sku.HasValue()) { skus.Add(sku); }
            }

            return skus;
        }
    }
}
