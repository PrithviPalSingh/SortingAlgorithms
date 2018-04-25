using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Divide an array into two halves
    /// Recursively sort each half
    /// Merge the two halves
    /// 1. Mantain an auxiliary array
    /// 2. Maintain three pointers for left half, right half and merged array.
    /// 3. Compare item in i and j, place the samller one in k (say j is small)
    /// 4. Increment j and k by 1.
    /// Extra space is used as a new auxiliary array is used
    /// Merge sort is optimal with respect to number of compaisons
    /// Merge sort is not optimal w.r.t space usage
    /// A stable sort perserves relative order of items with equal key
    /// MERGE SORT and INSERTION SORT are stable
    /// SELECTION and SHELL SORT are not
    /// </summary>
    class MergeSort
    {
        public void Sort(int[] arr)
        {
            int[] auxArray = new int[arr.Length];
            Sort(arr, auxArray, 0, arr.Length - 1);
            Utilities.Print(arr);
        }

        /// <summary>
        /// Pass through array, merging subarrays of size 1.
        /// Repeat for subarrays of size 2,4,8,16...........
        /// </summary>
        /// <param name="arr"></param>
        public void BottomUpMergeSort(int[] arr)
        {
            int N = arr.Length;
            int[] auxArray = new int[N];
            for (int sz = 1; sz < N; sz = sz + sz)
            {
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                {
                    Merge(arr, auxArray, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
                }
            }

            Utilities.Print(arr);
        }

      

        private void Sort(int[] arr, int[] auxArray, int low, int high)
        {
            if (high <= low)
            {
                return;
            }

            int mid = low + (high - low) / 2;
            Sort(arr, auxArray, low, mid);
            Sort(arr, auxArray, mid + 1, high);
            Merge(arr, auxArray, low, mid, high);
        }

        /// <summary>
        /// Pre-condition: Low-to-Mid is sorted and Mid-to-high is sorted.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="auxArray"></param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        private void Merge(int[] arr, int[] auxArray, int low, int mid, int high)
        {
            int N = arr.Length;
            for (int k = 0; k < N; k++)
            {
                auxArray[k] = arr[k];
            }

            int i = low;
            int j = mid + 1;
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    arr[k] = auxArray[j++];
                }
                else if (j > high)
                {
                    arr[k] = auxArray[i++];
                }
                else if (Utilities.Less(auxArray[j], auxArray[i]))
                {
                    arr[k] = auxArray[j++];
                }
                else
                {
                    arr[k] = auxArray[i++];
                }
            }
        }
    }
}
