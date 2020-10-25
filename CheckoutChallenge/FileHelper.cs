using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CheckoutChallenge.Helpers
{
    public static class FileHelper
    {
        internal static List<string[]> ReadSKUValuesFromFile(string fileName)
        {
            try
            {
                var skuValues = new List<string[]>();

                //assume first line is a header so skip it
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
