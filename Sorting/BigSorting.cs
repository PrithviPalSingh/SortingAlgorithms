using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BigSorting
    {
        public string[] Sort(string[] arr)
        {
            int N = arr.Length;

            for (int i = 0; i < N; i++)
            {
                var r = new Random();
                Exchange(arr, r.Next(0, i + 1), i);
            }

            Sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void Sort(string[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int j = Partition(arr, low, high);
            Sort(arr, low, j - 1);
            Sort(arr, j + 1, high);
        }

        public static int Partition(string[] arr, int low, int high)
        {
            StringComparer sc = new StringComparer();
            int i = low;
            int j = high + 1;
            while (true)
            {
                while (sc.Compare(arr[++i], arr[low]) == -1)
                {
                    if (i == high)
                        break;
                }

                while (sc.Compare(arr[--j], arr[low]) == 1)
                {
                    if (j == low)
                        break;
                }

                if (i >= j)
                    break;

                Exchange(arr, i, j);
            }

            Exchange(arr, low, j);
            return j;
        }

        private static void Exchange(string[] arr, int minIndex, int indextoSwap)
        {
            var swap = arr[minIndex];
            arr[minIndex] = arr[indextoSwap];
            arr[indextoSwap] = swap;
        }

        private class StringComparer : IComparer<string>
        {
            public int Compare(string str1, string str2)
            {
                var p1 = str1.ToCharArray();
                var p2 = str2.ToCharArray();
                if (p1.Length > p2.Length)
                {
                    return 1;
                }
                else if (p2.Length > p1.Length)
                {
                    return -1;
                }
                else
                {
                    for (int i = 0; i < p1.Length; i++)
                    {
                        if (Convert.ToInt16(p1[i]) > Convert.ToInt16(p2[i]))
                        {
                            return 1;
                        }
                        else if (Convert.ToInt16(p1[i]) < Convert.ToInt16(p2[i]))
                        {
                            return -1;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                return 0;
            }
        }
    }
}
