using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool NullSafeAny<T>(IEnumerable<T> input)
        {
            if (input is null) { return false; }

            return input.Any(); 
        }
    }
}
