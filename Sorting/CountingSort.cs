using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class CountingSort
    {
        public int[] countingSort(int[] arr)
        {
            int n = arr.Length;
            int[] count = new int[n + 1];
            int[] finalArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                count[arr[i] + 1]++;
            }

            for (int i = 0; i < n; i++)
            {
                count[i + 1] += count[i];
            }

            for (int i = 0; i < n; i++)
            {
                finalArray[count[arr[i]]++] = arr[i];
            }

            return finalArray;
        }
    }
}
