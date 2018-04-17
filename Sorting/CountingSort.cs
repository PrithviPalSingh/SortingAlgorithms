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
            int[] count = new int[n];
            int[] finalArray = new int[n];
            //int[] arrNew = new int[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arrTemp[arr[i]]++;
            //}

            //int k = 0;

            //for (int i = 0; i < arrTemp.Length; i++)
            //{
            //    if (arrTemp[i] == 0)
            //        continue;

            //    int j = i;
            //    while (arrTemp[j] > 0)
            //    {
            //        arrNew[k] = j;
            //        arrTemp[j]--;
            //        k++;
            //    }
            //}

            //return arrNew;

            for (int i = 0; i < n; i++)
            {
                ++count[arr[i]];
            }

            for (int i = 1; i < n; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                finalArray[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }

            return finalArray;
        }
    }
}
