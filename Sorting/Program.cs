using System;
using System.Collections.Generic;
using System.Drawing;
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
            //Shuffling.Shuffle(items3);

            //8. Classic Merge Sort
            //MergeSort ms = new MergeSort();
            //int N = 100000;
            //int[] items4 = new int[N];// Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //for (int i = 0; i < N; i++)
            //{
            //    items4[i] = N - i;
            //}
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
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = { "63", "25", "73", "1", "98", "73", "56", "84", "86", "57", "16", "83", "8", "25", "81", "56", "9", "53", "98",
            //    "67", "99", "12", "83", "89", "80", "91", "39", "86", "76", "85", "74", "39", "25", "90", "59", "10", "94", "32", "44", "3", "89",
            //    "30", "27", "79", "46", "96", "27", "32", "18", "21", "92", "69", "81", "40", "40", "34", "68", "78", "24", "87", "42", "69", "23",
            //    "41", "78", "22", "6", "90", "99", "89", "50","30", "20", "1", "43", "3", "70", "95", "33", "46", "44", "9", "69", "48", "33", "60",
            //    "65", "16", "82", "67", "61", "32", "21", "79", "75", "75", "13", "87", "70", "33" };// Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //CountingSort cs = new CountingSort();
            //int[] result = cs.countingSort(arr);
            //Console.WriteLine(String.Join(" ", result));

            ////18. Full counting sort
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = { 0, 6, 0, 6, 4, 0, 6, 0, 6, 0, 4, 3, 0, 1, 5, 1, 2, 4, 2, 4 };
            //string[] arr2 = { "ab", "cd", "ef", "gh", "ij", "ab", "cd", "ef", "gh", "ij", "that", "be", "to", "be", "question", "or", "not", "is", "to", "the" };
            //FullCountingSort fcs = new FullCountingSort();
            //fcs.Sort(n, arr1, arr2);

            ////19. Heap Sort
            //char[] charArray = { 'H', 'E', 'A', 'P', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            //int[] arr1 = { 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            //HeapSort hs = new HeapSort();
            //hs.Sort(arr1);

            //20. Convex hull
            //Point2D p = new Point2D(2, 1);
            //Point a = new Point(1, 1);
            //Point b = new Point(0, 4);
            //Point c = new Point(2, 5);
            //Console.WriteLine(Point2D.CCW(a, b, c));
            List<Point2D> hull = new List<Point2D>();
            hull.Add(new Point2D(0, 0));
            hull.Add(new Point2D(0, 10));
            hull.Add(new Point2D(-2, 8));
            hull.Add(new Point2D(-1, 3));
            hull.Add(new Point2D(-4, 9));
            hull.Add(new Point2D(-6, 12));
            hull.Add(new Point2D(-4, 4));
            hull.Add(new Point2D(-5, 5));
            hull.Add(new Point2D(-8, 6));
            hull.Add(new Point2D(-9, 4));
            hull.Add(new Point2D(-7, 3));
            hull.Add(new Point2D(-4, 2));
            hull.Add(new Point2D(-7, 1));
            ConvexHull ch = new ConvexHull();
            ch.FindHull(hull.ToArray());

            Console.Read();
        }


    }
}
