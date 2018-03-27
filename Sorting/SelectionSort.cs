using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SelectionSort
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    loop++;
                    if (Compare(items[i], items[j]))
                    {
                        comparison++;
                        Exchange(items, i, j);
                    }
                }
            }

            print(items);
            Console.WriteLine();
            Console.WriteLine("loop" + loop);
            Console.WriteLine("comparison" + comparison);
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
