using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Shell sorting
    /// </summary>
    class H_Sorting
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;

            int h = 1;

            while (h < N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h; j -= h)
                    {
                        loop++;
                        if (Utilities.Greater(items[j - h], items[j]))
                        {
                            comparison++;
                            Utilities.Exchange(items, j - h, j);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                h = h / 3;
            }

            Utilities.Print(items);
            Console.WriteLine();
            Console.WriteLine("loop" + loop);
            Console.WriteLine("comparison" + comparison);
        }       
    }
}
