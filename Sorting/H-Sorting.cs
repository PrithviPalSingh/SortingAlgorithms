using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Shell sorting
    /// A g-Sorted array remains g-Sorted even after h-Sorting it.
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
                        if (Utilities.Less(items[j], items[j - h]))
                        {
                            comparison++;
                            Utilities.Exchange(items, j, j - h);
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
