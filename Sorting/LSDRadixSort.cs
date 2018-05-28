using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class LSDRadixSort
    {
        public string[] Sort(string[] arr, int W)
        {
            int R = 256;
            int n = arr.Length;            
            string[] aux = new string[n];

            for (int d = W-1; d >= 0; d--)
            {
                int[] count = new int[R + 1];
                for (int i = 0; i < n; i++)
                {
                    count[arr[i][d] + 1]++;
                }

                for (int r = 0; r < R; r++)
                {
                    count[r + 1] += count[r];
                }

                for (int i = 0; i < n; i++)
                {
                    aux[count[arr[i][d]]++] = arr[i];
                }

                for (int i = 0; i < n; i++)
                {
                    arr[i] = aux[i];
                }
            }          

            return arr;
        }
    }
}
