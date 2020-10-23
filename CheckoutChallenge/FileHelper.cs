using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CheckoutChallenge
{
    public static class FileHelper
    {
        internal static List<string[]> ReadSKUValuesFromFile(string fileName)
        {
            try
            {
                var skuValues = new List<string[]>();

                var lines = File.ReadAllLines(fileName).Skip(1);

                foreach (var line in lines)
                {
                    skuValues.Add(line.Split(','));
                }

                return skuValues;
            }
            catch
            {
                throw new Exception("Error parsing file.");
            }
        }
    }
}
