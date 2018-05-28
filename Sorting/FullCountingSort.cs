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
            int R = arr1.Distinct().Count();
            int[] count = new int[R + 1];
            int[] finalArray = new int[n];
            string[] finalStringArray = new string[n];

            for (int i = 0; i < n / 2; i++)
            {
                arr2[i] = "-";
            }

            for (int i = 0; i < n; i++)
            {
                ++count[arr1[i] + 1];
            }

            for (int i = 0; i < R; i++)
            {
                count[i + 1] += count[i];
            }

            for (int i = 0; i < n; i++)
            {
                finalArray[count[arr1[i]]] = arr1[i];
                finalStringArray[count[arr1[i]]] = arr2[i];
                count[arr1[i]]++;
            }
            
            Console.WriteLine(string.Join(" ", finalStringArray));
        }

        private void Sort(int[] arr, int[] auxArray, int[] arrInt, int[] arr2Aux, int low, int high)
        {
            if (high <= low)
            {
                return;
            }

            int mid = low + (high - low) / 2;
            Sort(arr, auxArray, arrInt, arr2Aux, low, mid);
            Sort(arr, auxArray, arrInt, arr2Aux, mid + 1, high);
            Merge(arr, auxArray, arrInt, arr2Aux, low, mid, high);
        }

        private void Merge(int[] arr, int[] auxArray, int[] arrInt, int[] arr2Aux, int low, int mid, int high)
        {
            int N = arr.Length;
            for (int k = 0; k < N; k++)
            {
                auxArray[k] = arr[k];
                arr2Aux[k] = arrInt[k];
            }

            int i = low;
            int j = mid + 1;
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    arr[k] = auxArray[j];
                    arrInt[k] = arr2Aux[j];
                    j++;
                }
                else if (j > high)
                {
                    arr[k] = auxArray[i];
                    arrInt[k] = arr2Aux[i];
                    i++;
                }
                else if (Less(auxArray[j], auxArray[i]))
                {
                    arr[k] = auxArray[j];
                    arrInt[k] = arr2Aux[j];
                    j++;
                }
                else
                {
                    arr[k] = auxArray[i];
                    arrInt[k] = arr2Aux[i];
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
