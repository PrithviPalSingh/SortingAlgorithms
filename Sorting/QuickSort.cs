using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort
    {
        /// <summary>
        ///  1. Shuffle and array
        ///  2. Partition such that, for some j
        ///     2.1 Entry a[j] is in place
        ///     2.2 No larger element to left of j
        ///     2.3 No smaller item to right of j
        ///  3. Sort each piece recursively
        ///  4. 1 Parition element, 1 pointer that moves forward and 1 pointer that moves backward
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(int[] arr)
        {
            Shuffling.Shuffle(arr);
            Sort(arr, 0, arr.Length - 1);
            Utilities.Print(arr);
        }

        /// <summary>
        /// Compares ~ 2N
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Select(int[] arr, int k)
        {
            Shuffling.Shuffle(arr);

            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int j = Partition(arr, low, high);
                if (j > k)
                {
                    high = j - 1;
                }
                else if (j < k)
                {
                    low = j + 1;
                }
                else
                {
                    return arr[k];
                }
            }

            return arr[k];
        }

        private void Sort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int j = Partition(arr, low, high);
            Sort(arr, low, j - 1);
            Sort(arr, j + 1, high);
        }

        private int Partition(int[] items, int low, int high)
        {
            int N = items.Length;
            int i = low;
            int j = high + 1;
            while (true)
            {
                while (Utilities.Less(items[++i], items[low]))
                {
                    if (i == high)
                        break;
                }

                while (Utilities.Less(items[low], items[--j]))
                {
                    if (j == low)
                        break;
                }

                if (i >= j)
                    break;

                Utilities.Exchange(items, i, j);
            }

            Utilities.Exchange(items, low, j);

            return j;
        }

    }
}
