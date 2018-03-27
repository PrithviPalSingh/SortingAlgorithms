using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class H_Sorting
    {
        public void Sort(int[] items)
        {
            int N = items.Length;
            int loop = 0;
            int comparison = 0;

            int h = 1;

            while (h < N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h; j -= h)
                    {
                        loop++;
                        if (Compare(items[j - h], items[j]))
                        {
                            comparison++;
                            Exchange(items, j - h, j);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                h = h / 3;
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
