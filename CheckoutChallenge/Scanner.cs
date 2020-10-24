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
                int parsedPrice;
                int? parsedSpecialQuantity = null;
                int? parsedSpecialPrice = null;

                if (Int32.TryParse(price, out var tempPriceVal))
                {
                    if(tempPriceVal > 0)
                    {
                        parsedPrice = tempPriceVal;
                    }
                    else
                    {
                        throw new Exception("Item price should be greater than zero.");
                    }
                }
                else
                {
                    throw new Exception("Error parsing item price.");
                }

                if(!string.IsNullOrEmpty(specialQuantity))
                {
                    if (Int32.TryParse(specialQuantity, out var tempSpecialQuantityVal))
                    {
                        if (tempSpecialQuantityVal > 0)
                        {
                            parsedSpecialQuantity = tempSpecialQuantityVal;
                        }
                        else
                        {
                            throw new Exception("Special quantity should be greater than zero.");
                        }
                    }
                    else
                    {
                        throw new Exception("Error parsing special quantity.");
                    }
                }
                
                if(!string.IsNullOrEmpty(specialPrice))
                {
                    if (Int32.TryParse(specialPrice, out var tempSpecialPriceVal))
                    {
                        if (tempSpecialPriceVal > 0)
                        {
                            parsedSpecialPrice = tempSpecialPriceVal;
                        }
                        else
                        {
                            throw new Exception("Special price should be greater than zero.");
                        }
                    }
                    else
                    {
                        throw new Exception("Error parsing special price.");
                    }
                }

                return new StockKeepingUnit(item, parsedPrice, parsedSpecialQuantity, parsedSpecialPrice);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
