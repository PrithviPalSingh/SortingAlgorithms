using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// N^2/2 - elements are traveres while sorting
    /// Quadratic time even if array is sorted
    /// </summary>
    class SelectionSort
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    loop++;
                    if (Utilities.Less(items[j], items[min]))
                    {
                        comparison++;
                        min = j;
                    }
                }

                Utilities.Exchange(items, i, min);
            }

            Utilities.Print(items);
            Console.WriteLine();
            Console.WriteLine("loop" + loop);
            Console.WriteLine("comparison" + comparison);
        }
    }
}
