using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class HeapSort
    {
        /// <summary>
        /// 1. Create binary heap
        /// 2. Rearrange by continuously shifting max value to end
        /// </summary>
        /// <param name="charArray"></param>
        public void Sort(int[] charArray)
        {
            int N = charArray.Length;
            for (int i = N / 2; i >= 0; i--)
            {
                Sink(charArray, i, N);
            }

            while (N > 0)
            {
                Exchange(charArray, 0, N - 1);
                Sink(charArray, 0, --N);
            }

            Console.WriteLine(string.Join(" ", charArray));
        }       

        private void Sink(int[] arr, int k, int N)
        {
            while (2 * k < N)
            {
                int j = 2 * k;

                if (j < N - 1 && Less(arr,j, j + 1))
                    j++;

                if (!Less(arr, k, j))
                    break;

                Exchange(arr, k, j);
                k = j;
            }
        }

        private bool Less(int[] arr, int i, int j)
        {
            return arr[i].CompareTo(arr[j]) < 0;
        }

        private void Exchange(int[] arr, int i, int j)
        {
            var swap = arr[i];
            arr[i] = arr[j];
            arr[j] = swap;
        }

        private void Swim(int[] arr, int k)
        {
            while (k > 0 && Less(arr, k / 2, k))
            {
                Exchange(arr, k, k / 2);
                k = k / 2;
            }
        }
    }
}
