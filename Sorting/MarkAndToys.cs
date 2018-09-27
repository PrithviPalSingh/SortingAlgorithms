using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MarkAndToys
    {
        public static long maximumToys(int[] prices, int k)
        {
            Array.Sort(prices);
            long sum = 0;
            long count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];

                if (sum <= k)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
