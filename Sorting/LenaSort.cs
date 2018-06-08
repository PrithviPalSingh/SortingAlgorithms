using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class LenaSort
    {
        const int MAXN = 100005;
        List<int>[] A = new List<int>[MAXN];
        List<int>[] G = new List<int>[MAXN];
        int[] ctr = new int[MAXN];
        int[] val = new int[MAXN];
        int cval;
        void label_tree(int pos)
        {
            if (G[pos].Count >= 1)
                label_tree(G[pos][0]);

            val[pos] = cval;

            ++cval;

            if (G[pos].Count >= 2)
                label_tree(G[pos][1]);
        }
        void print_tree(int pos)
        {
            //cout << val[pos] << " ";
            Console.Write(val[pos] + 1 + " ");
            for (int i = 0; i < G[pos].Count; ++i)
            {
                print_tree(G[pos][i]);
            }
        }


        public void ConstructArray(int n, int c)
        {            
            int cval;
            //cin >> n >> c;
            long curr = 0;
            int ptr = 1;
            for (int i = 0; i < n; ++i)
            {
                ctr[i] = 1;
                curr += i;
            }

            for (int i = 0; i < MAXN; i++)
            {
                A[i] = new List<int>();
                G[i] = new List<int>();
            }

            for (int i = n - 1; i > ptr && curr > c; --i)
            {
                int max_reduce = i - ptr;
                int to_reduce = (int)Math.Min(max_reduce, curr - c);
                curr -= to_reduce;
                ctr[i] = 0;
                ctr[i - to_reduce]++;
                if (ctr[ptr] == 2 * ctr[ptr - 1])
                    ptr++;
            }
            if (curr != c)
            {
                Console.WriteLine(-1);
                //continue;
            }
            cval = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < ctr[i]; ++j)
                {
                    A[i].Add(cval);
                    ++cval;
                }
            }
            for (int i = 1; i < n; ++i)
            {
                G[i] = new List<int>();
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
            for (int i = 0; i < n; ++i)
            {
                A[i].Clear();
                G[i].Clear();
            }

            //return 0;
        }
    }
}
