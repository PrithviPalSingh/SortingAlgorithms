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

            ////1.Insertion sort
            //InsertionSort ins = new InsertionSort();
            //int[] items = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //ins.Sort(items);

            ////2. Insertion sort using IComparable
            //InsertionSort ins = new InsertionSort();
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //IComparable[] items = new IComparable[a.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    items[i] = a[i];
            //}
            //ins.InsertionSortUsingIComparable(items);


            ////3. Insertion Sort hacker rank
            //InsertionSort ins = new InsertionSort();
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //ins.insertionSort1(n, arr);

            ////4. Insertion sort hacker rank
            //InsertionSort ins = new InsertionSort();
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //ins.insertionSort2(n, arr);

            ////5. Selection sort
            //SelectionSort ss = new SelectionSort();
            //int[] items1 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //ss.Sort(items1);

            ////6. H-Sorting
            //H_Sorting hs = new H_Sorting();
            //int[] items2 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //hs.Sort(items2);

            //7. Shuffle
            //Shuffling sf = new Shuffling();
            //int[] items3 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //sf.shuffle(items3);

            //8. Classic Merge Sort
            //MergeSort ms = new MergeSort();
            //int[] items4 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //ms.Sort(items4);

            ////9.Bottom up merge sort
            //MergeSort bums = new MergeSort();
            //int[] items5 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //bums.BottomUpMergeSort(items5);

            //10. Quick Sort
            //QuickSort qs = new QuickSort();
            //int[] items6 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //qs.Sort(items6);
            //Console.WriteLine(qs.Select(items6, 9));

            ////11. Quick sort select
            //QuickSort qs = new QuickSort();
            //int[] items7 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));           
            //Console.WriteLine(qs.Select(items7, 1));

            //12. Dijkstra's 3-Way sort
            //Dijkstra3WaySorting d3s = new Dijkstra3WaySorting();
            //int[] items8 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //d3s.Sort(items8);

            ////14. Big sorting
            //BigSorting bs = new BigSorting();
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr = new string[n];
            //for (int arr_i = 0; arr_i < n; arr_i++)
            //{
            //    arr[arr_i] = Console.ReadLine();
            //}
            //string[] result = bs.Sort(arr);
            //Console.WriteLine(String.Join("\n", result));

            //15. Hackerrank intro challenge
            //int V = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //HackerRankIntroChallenge hrc = new HackerRankIntroChallenge();
            //int result = hrc.introTutorial(V, arr);
            //Console.WriteLine(result);

            ////16. Quick sort hacker rank
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //Quicksort1 qs1 = new Quicksort1();
            //int[] result = qs1.quickSort(arr);
            //Console.WriteLine(String.Join(" ", result));

            ////17. Counting sort
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            CountingSort cs = new CountingSort();
            int[] result = cs.countingSort(arr);
            Console.WriteLine(String.Join(" ", result));

            Console.Read();
        }       

       
    }
}
