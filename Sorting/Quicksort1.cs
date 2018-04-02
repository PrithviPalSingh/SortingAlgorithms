using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quicksort1
    {
        public int[] quickSort(int[] arr)
        {
            int p = arr[0];
            int N = arr.Length;
            int i = 0;
            int j = 0;
            int k = 0;
            int[] left = new int[N] ;
            int[] equal = new int[N];
            int[] right = new int[N];

            for (int l = 0; l < N; l++)
            {
                left[l] = -1;
                equal[l] = -1;
                right[l] = -1;
            }

            for (int l = 0; l < N; l++)
            {
                if (p > arr[l])
                {
                    left[i++] = arr[l];
                }
                else if (p < arr[l])
                {
                    right[j++] = arr[l];
                }
                else
                {
                    equal[k++] = arr[l];
                }
            }

            int t = 0;
            for (int l = 0; l < left.Length; l++)
            {
                if (left[l] != -1)
                    arr[t++] = left[l];
            }

            for (int l = 0; l < equal.Length; l++)
            {
                if (equal[l] != -1)
                    arr[t++] = equal[l];
            }

            for (int l = 0; l < right.Length; l++)
            {
                if (right[l] != -1)
                    arr[t++] = right[l];
            }

            return arr;
        }
        
    }
}
