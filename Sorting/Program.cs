using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Area to call sorting algorithms
             * */

            //1. Insertion sort
            //int[] items = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //InsertionSort(items);

            //2. Insertion sort using IComparable
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //IComparable[] items = new IComparable[a.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    items[i] = a[i];
            //}
            //InsertionSortUsingIComparable(items);
            //PrintArray(items);

            //3. Insertion Sort hacker rank
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);            
            //insertionSort1(n, arr);

            //4. Insertion sort hacker rank
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            insertionSort2(n, arr);

            Console.Read();
        }

        private static void InsertionSort(int[] items)
        {
            int length = items.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
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

        private static void InsertionSortUsingIComparable(IComparable[] items)
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

        private static void Exchange(IComparable[] a, int lower, int upper)
        {
            IComparable swap = a[lower];
            a[lower] = a[upper];
            a[upper] = swap;
        }

        private static void PrintArray(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
        }

        static void insertionSort1(int n, int[] arr)
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

                PrintArray(arr);
                Console.WriteLine();

                if (i == 0 || arr[i - 1] < lastItem) { break; }
            }

            //if (i == -1)
            //{
            //    arr[i + 1] = lastItem;
            //    PrintArray(arr);
            //}
        }

        static void insertionSort2(int n, int[] arr)
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

                PrintArray(arr);
                Console.WriteLine();
            }
        }
    }
}
