using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Shuffling
    {
        public void shuffle(int[] items)
        {
            int N = items.Length;

            for (int i = 0; i < N; i++)
            {
                var r = new Random();
                Exchange(items, r.Next(0, i + 1), i);
            }

            print(items);
        }

        private void print(int[] items)
        {
            int N = items.Length;

            for (int i = 0; i < N; i++)
            {
                Console.Write(items[i] + " ");
            }
        }

        private void Exchange(int[] arr, int minIndex, int indextoSwap)
        {
            var swap = arr[minIndex];
            arr[minIndex] = arr[indextoSwap];
            arr[indextoSwap] = swap;
        }
    }
}
