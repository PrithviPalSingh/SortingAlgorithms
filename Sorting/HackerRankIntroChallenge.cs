using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class HackerRankIntroChallenge
    {
        public int introTutorial(int v, int[] arr)
        {
            int N = arr.Length;
            int[] arrTemp = new int[N];
            Sort(arr, arrTemp, 0, arr.Length - 1);
            Utilities.Print(arr);
            int itemLocation = 0;
            BinarySearch(arr, v, 0, arr.Length, ref itemLocation);
            return itemLocation;
        }

        private void BinarySearch(int[] arr, int V, int low, int high, ref int i)
        {
            if (low > high)
                return ;

            int mid = low + (high - low) / 2;

            if (V == arr[mid])
            {
                i = mid;
            }
            else if (V > arr[mid])
            {
                BinarySearch(arr, V, mid + 1, high, ref i);
            }
            else
            {
                BinarySearch(arr, V, low, mid - 1, ref i);
            }
        }

        private void Sort(int[] arr, int[] arrTemp, int low, int high)
        {
            if (low >= high)
                return;

            int mid = low + (high - low) / 2;
            Sort(arr, arrTemp, low, mid);
            Sort(arr, arrTemp, mid + 1, high);
            Merge(arr, arrTemp, low, mid, high);
        }

        private void Merge(int[] arr, int[] arrTemp, int low, int mid, int high)
        {
            int N = arr.Length;
            for (int t = 0; t < N; t++)
            {
                arrTemp[t] = arr[t];
            }

            int i = low;
            int j = mid + 1;
            int k = low;

            while (k <= high)
            {
                if (i > mid)
                {
                    arr[k++] = arrTemp[j++];
                }
                else if (j > high)
                {
                    arr[k++] = arrTemp[i++];
                }
                else if (arrTemp[i] <= arrTemp[j])
                {
                    arr[k++] = arrTemp[i++];
                }
                else
                {
                    arr[k++] = arrTemp[j++];
                }
            }
        }

        private void Exchange(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
