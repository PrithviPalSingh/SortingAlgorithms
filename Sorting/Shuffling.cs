using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Shuffling
    {
        public static void Shuffle(int[] items)
        {
            int N = items.Length;

            for (int i = 0; i < N; i++)
            {
                var r = new Random();
                Utilities.Exchange(items, r.Next(0, i + 1), i);
            }

            Utilities.Print(items);
        }
    }
}
