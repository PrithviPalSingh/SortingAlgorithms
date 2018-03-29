using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort
    {
        public void Sort(int[] arr)
        {
            int[] auxArray = new int[arr.Length];
            Sort(arr, auxArray, 0, arr.Length - 1);
            Utilities.Print(arr);
        }

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
                else if (Utilities.Greater(auxArray[j], auxArray[i]))
                {
                    arr[k] = auxArray[i++];
                }
                else
                {
                    arr[k] = auxArray[j++];
                }
            }
        }
    }
}
