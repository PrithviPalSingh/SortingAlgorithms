using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    loop++;
                    var swap = items[j - 1];
                    if (Compare(items[j - 1], items[j]))
                    {
                        comparison++;
                        items[j - 1] = items[j];
                        items[j] = swap;
                    }
                }
            }

            print(items);
            Console.WriteLine();
            Console.WriteLine("loop" + loop);
            Console.WriteLine("comparison" + comparison);
        }

        void InsertionSortUsingIComparable(IComparable[] items)
        {
            int length = items.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    var swap = items[j - 1];
                    if (items[j - 1].CompareTo(items[j]) > 0)
                    {
                        items[j - 1] = items[j];
                        items[j] = swap;
                    }
                }
            }
        }
        
        void insertionSort1(int n, int[] arr)
        {
            var lastItem = arr[n - 1];
            int i;
            for (i = n - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    arr[i] = lastItem;
                }
                if (arr[i - 1] > lastItem)
                {
                    arr[i] = arr[i - 1];
                }
                else if (arr[i - 1] <= lastItem)
                {
                    arr[i] = lastItem;
                }

                print(arr);
                Console.WriteLine();

                if (i == 0 || arr[i - 1] < lastItem) { break; }
            }
        }

        void insertionSort2(int n, int[] arr)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    var swap = arr[j - 1];
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        arr[j - 1] = arr[j];
                        arr[j] = swap;
                    }
                }

                print(arr);
                Console.WriteLine();
            }
        }

        private void print(int[] items)
        {
            int N = items.Length;

            for (int i = 0; i < N; i++)
            {
                Console.Write(items[i] + " ");
            }
        }

        private bool Compare(int a, int b)
        {
            return a > b;
        }

        private void Exchange(int[] arr, int minIndex, int indextoSwap)
        {
            var swap = arr[minIndex];
            arr[minIndex] = arr[indextoSwap];
            arr[indextoSwap] = swap;
        }
    }
}
