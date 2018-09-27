using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public struct Player
    {
        public int score;
        public string name;
    };

    class Comparator
    {
        static long count = 0;
        static int comparator(Player a, Player b)
        {
            if (a.score > b.score)
            {
                return 1;
            }
            else if (a.score < b.score)
            {
                return -1;
            }
            else if (a.score == b.score)
            {
                if (string.Compare(a.name, b.name) < 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            return 0;
        }

        public static long countInversions1(int[] arr)
        {
            //long swaps = 0;
            //bool stopcompare = false;
            //while (!stopcompare)
            //{
            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            var temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //            swaps++;
            //            stopcompare = false;
            //            break;
            //        }

            //        stopcompare = true;
            //    }
            //}

            //return swaps;

            int[] auxArray = new int[arr.Length];
            Sort(arr, auxArray, 0, arr.Length - 1);
            return count;
        }


        private static void Sort(int[] arr, int[] auxArray, int low, int high)
        {
            //long count = 0;
            if (high <= low)
            {
                return;
            }

            int mid = low + (high - low) / 2;
            Sort(arr, auxArray, low, mid);
            Sort(arr, auxArray, mid + 1, high);
            Merge(arr, auxArray, low, mid, high);
            //return count;
        }

        /// <summary>
        /// Pre-condition: Low-to-Mid is sorted and Mid-to-high is sorted.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="auxArray"></param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        private static void Merge(int[] arr, int[] auxArray, int low, int mid, int high)
        {
            //long count = 0;
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
                    count += mid + 1 - i;
                }
                else
                {
                    arr[k] = auxArray[i++];
                }
            }

            //return count;
        }


        #region

        private static long swaps = 0;

        public static long countInversions(int[] array)
        {
            swaps = 0;
            int[] helper = new int[array.Length];
            mergeSort(array, helper, 0, array.Length - 1);
            return swaps;
        }

        private static void mergeSort(int[] array, int[] helper, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(array, helper, start, mid);
                mergeSort(array, helper, mid + 1, end);
                merge(array, helper, start, mid, end);
            }
        }

        private static void merge(int[] array, int[] helper, int start, int mid, int end)
        {

            /* Fill helper array with same elements as original array */
            for (int i = start; i <= end; i++)
            { // notice "i" goes from "start" to "end", not "0" to "array.length"
                helper[i] = array[i];
            }

            int curr = start;
            int left = start;
            int right = mid + 1;

            /* Loop through helper[] left and right halves and continuously copy smaller element to array[] */
            while (left <= mid && right <= end)
            {
                if (helper[left] <= helper[right])
                {
                    array[curr++] = helper[left++];
                }
                else
                {
                    /* Each time we choose element from right side, we count up how many elements
                       it is less than from left side. This is equivalent to counting swaps. */
                    swaps += mid + 1 - left;
                    array[curr++] = helper[right++];
                }
            }

            /* Copy remaining elements of left half. Right half elements are already in proper place */
            while (left <= mid)
            {
                array[curr++] = helper[left++];
            }
        }
        #endregion
    }
}
