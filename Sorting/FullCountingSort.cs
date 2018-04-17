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
            int[] count = new int[n];
            int[] finalArray = new int[n];
            string[] finalStringArray = new string[n];

            for (int i = 0; i < n/2; i++)
            {
                arr2[i] = "-";
            }

            for (int i = 0; i < n; i++)
            {
                ++count[arr1[i]];
            }

            for (int i = 1; i < n; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                finalArray[count[arr1[i]] - 1] = arr1[i];
                finalStringArray[count[arr1[i]] - 1] = arr2[i];
                --count[arr1[i]];
            }

            int[] count1 = new int[n];
            int[] finalArray1 = new int[n];
            string[] finalStringArray1 = new string[n];

            for (int i = 0; i < n; i++)
            {
                ++count1[finalArray[i]];
            }

            for (int i = 1; i < n; i++)
            {
                count1[i] += count1[i - 1];
            }

            for (int i = 0; i < n; i++)
            {
                finalArray1[count1[finalArray[i]] - 1] = finalArray[i];
                finalStringArray1[count1[finalArray[i]] - 1] = finalStringArray[i];
                --count1[finalArray[i]];
            }

            //Console.WriteLine(string.Join(" ", finalArray));
            //Console.WriteLine(string.Join(" ", finalStringArray));
            //Console.WriteLine(string.Join(" ", finalArray1));
            Console.WriteLine(string.Join(" ", finalStringArray1));
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
