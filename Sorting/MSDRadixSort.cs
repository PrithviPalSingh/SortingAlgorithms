using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MSDRadixSort
    {
        private static int R = 256;

        public void Sort(string[] arr)
        {
            string[] aux = new string[arr.Length];
            Sort(arr, aux, 0, aux.Length - 1, 0);
        }

        private static void Sort(string[] arr, string[] aux, int low, int high, int d)
        {
            if (high <= low)
                return;

            int[] count = new int[R + 2];

            for (int i = low; i <= high; i++)
            {
                count[arr[i][d] + 2]++;
            }

            for (int r = 0; r < R + 1; r++)
            {
                count[r + 1] += count[r];
            }

            for (int i = low; i <= high; i++)
            {
                aux[count[arr[i][d] + 1]++] = arr[i];
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = aux[i - low];
            }

            for (int r = 0; r < R; r++)
            {
                Sort(arr, aux, low + count[r], low + count[r + 1] - 1, d + 1);
            }
        }
    }
}
