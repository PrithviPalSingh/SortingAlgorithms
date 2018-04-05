using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Still not complete
    /// </summary>
    class FullCountingSort
    {
        public void Sort(int n, int[] arr1, string[] arr2)
        {
            ////int[] arrAux = new int[n];
            ////string[] arr2Aux = new string[n];
            for (int i = 0; i <= (n - 1) / 2; i++)
            {
                arr2[i] = "-";
            }

            //////Sort(arr1, arrAux, arr2, arr2Aux, 0, n - 1);

            //////Console.WriteLine(string.Join(" ", arr2));

            ////for (int sz = 1; sz < n; sz = sz + sz)
            ////{
            ////    for (int lo = 0; lo < n - sz; lo += sz + sz)
            ////    {
            ////        var low = lo;
            ////        var mid = lo + sz - 1;
            ////        var high = Math.Min(lo + sz + sz - 1, n - 1);
            ////        Merge(arr1, arrAux, arr2, arr2Aux, low, mid, high);
            ////    }
            ////}

            int[] arrTemp = new int[100];
            int[] arrNew = new int[n];
            string[] arrNewStr = new string[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                arrTemp[arr1[i]]++;
            }

            int k = 0;

            for (int i = 0; i < arrTemp.Length; i++)
            {
                if (arrTemp[i] == 0)
                    continue;

                int j = i;
                while (arrTemp[j] > 0)
                {
                    arrNew[k] = j;
                    arrNewStr[k] = arr2[arrTemp[j]];
                    arrTemp[j]--;
                    k++;
                }
            }

            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", arrNew));
            Console.WriteLine(string.Join(" ", arrNewStr));
        }

        private void Sort(int[] arr, int[] auxArray, string[] arr2, string[] arr2Aux, int low, int high)
        {
            if (high <= low)
            {
                return;
            }

            int mid = low + (high - low) / 2;
            Sort(arr, auxArray, arr2, arr2Aux, low, mid);
            Sort(arr, auxArray, arr2, arr2Aux, mid + 1, high);
            Merge(arr, auxArray, arr2, arr2Aux, low, mid, high);
        }

        private void Merge(int[] arr, int[] auxArray, string[] arr2, string[] arr2Aux, int low, int mid, int high)
        {
            int N = arr.Length;
            for (int k = 0; k < N; k++)
            {
                auxArray[k] = arr[k];
                arr2Aux[k] = arr2[k];
            }

            int i = low;
            int j = mid + 1;
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    arr[k] = auxArray[j];
                    arr2[k] = arr2Aux[j];
                    j++;
                }
                else if (j > high)
                {
                    arr[k] = auxArray[i];
                    arr2[k] = arr2Aux[i];
                    i++;
                }
                else if (Less(auxArray[j], auxArray[i]))
                {
                    arr[k] = auxArray[j];
                    arr2[k] = arr2Aux[j];
                    j++;
                }
                else
                {
                    arr[k] = auxArray[i];
                    arr2[k] = arr2Aux[i];
                    i++;
                }
            }
        }

        private bool Less(int a, int b)
        {
            return a.CompareTo(b) < 0;
        }
    }
}
