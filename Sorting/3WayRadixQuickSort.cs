using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class _3WayRadixQuickSort
    {
        public void Sort(string[] arr)
        {
            int N = arr.Length - 1;
            Sort(arr, 0, N, 0);
        }

        private void Sort(string[] arr, int low, int high, int d)
        {
            if (low >= high)
                return;

            int i = low + 1;
            int lt = low;
            int gt = high;
            int v = arr[low][d];

            while (i <= gt)
            {
                int t = arr[i][d];
                if (t > v)
                {
                    Utilities.Exchange(arr, i, gt--);
                }
                else if (t < v)
                {
                    Utilities.Exchange(arr, i++, lt++);
                }
                else
                {
                    i++;
                }
            }

            Sort(arr, low, lt - 1, d);
            if (v >= 0)
            {
                Sort(arr, lt, gt, d + 1);
            }
            Sort(arr, gt + 1, high, d);
        }
    }
}
