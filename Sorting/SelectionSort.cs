using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// N^2/2 - elements are traveres while sorting
    /// </summary>
    class SelectionSort
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;
            for (int i = 0; i < N - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {                    
                    loop++;
                    if (Utilities.Greater(items[min], items[j]))
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
