using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class LenaSort
    {
        //const long MAXN = 100005;
        List<long>[] A;//= new List<long>[MAXN];
        List<long>[] G;//= new List<long>[MAXN];
        long[] ctr;// = new long[MAXN];
        long[] val;// = new long[MAXN];
        long cval;
        void label_tree(long pos)
        {
            if (G[pos].Count >= 1)
                label_tree(G[pos][0]);

            val[pos] = cval;

            ++cval;

            if (G[pos].Count >= 2)
                label_tree(G[pos][1]);
        }
        void print_tree(long pos)
        {
            Console.Write(val[pos] + " ");
            for (int i = 0; i < G[pos].Count; ++i)
            {
                print_tree(G[pos][i]);
            }
        }


        public void ConstructArray(int t, long n, long c)
        {
            while (t-- != 0)
            {
                A = new List<long>[n];
                G = new List<long>[n];
                ctr = new long[n];
                val = new long[n];
                long curr = 0;
                long ptr = 1;
                for (long i = 0; i < n; ++i)
                {
                    ctr[i] = 1;
                    curr += i;
                }

                for (long i = 0; i < n; i++)
                {
                    A[i] = new List<long>();
                    G[i] = new List<long>();
                }

                for (long i = n - 1; i > ptr && curr > c; --i)
                {
                    long max_reduce = i - ptr;
                    long to_reduce = (long)Math.Min(max_reduce, curr - c);
                    curr -= to_reduce;
                    ctr[i] = 0;
                    ctr[i - to_reduce]++;
                    if (ctr[ptr] == 2 * ctr[ptr - 1])
                        ptr++;
                }
                if (curr != c)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                cval = 0;
                for (long i = 0; i < n; ++i)
                {
                    for (long j = 0; j < ctr[i]; ++j)
                    {
                        A[i].Add(cval);
                        ++cval;
                    }
                }
                for (long i = 1; i < n; ++i)
                {
                    G[i] = new List<long>();
                    for (int j = 0; j < ctr[i]; ++j)
                    {
                        G[A[i - 1][j / 2]].Add(A[i][j]);
                    }
                }
                cval = 1;
                label_tree(0);
                print_tree(0);
                Console.WriteLine();
                // cleanup
                for (long i = 0; i < n; ++i)
                {
                    A[i].Clear();
                    G[i].Clear();
                }

                //return 0;
            }
        }
    }
}
