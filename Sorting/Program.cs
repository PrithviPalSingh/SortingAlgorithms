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
            //int[] items6 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };// Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            //qs.Sort(items6);
            //Console.WriteLine(qs.Select(items6, 3));

            ////11. Quick sort select
            //QuickSort qs = new QuickSort();
            //int[] items7 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));           
            //Console.WriteLine(qs.Select(items7, 1));

            //12. Dijkstra's 3-Way sort
            //Dijkstra3WaySorting d3s = new Dijkstra3WaySorting();
            //int[] items8 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }; ;// Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
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
            //List<Point2D> hull = new List<Point2D>();
            //hull.Add(new Point2D(0, 0));
            //hull.Add(new Point2D(0, 10));
            //hull.Add(new Point2D(-2, 8));
            //hull.Add(new Point2D(-1, 3));
            //hull.Add(new Point2D(-4, 9));
            //hull.Add(new Point2D(-6, 12));
            //hull.Add(new Point2D(-4, 4));
            //hull.Add(new Point2D(-5, 5));
            //hull.Add(new Point2D(-8, 6));
            //hull.Add(new Point2D(-9, 4));
            //hull.Add(new Point2D(-7, 3));
            //hull.Add(new Point2D(-4, 2));
            //hull.Add(new Point2D(-7, 1));
            //ConvexHull ch = new ConvexHull();
            //ch.FindHull(hull.ToArray());

            ////21. LSD radix sort
            //string[] arr = { "dab", "add", "cab", "fad", "fee", "bad", "dad", "bee", "fed", "bed", "ebb", "ace" };
            //var result = new LSDRadixSort().Sort(arr, 3);
            //Console.WriteLine(string.Join(":", result));

            ////13. MSD radix sort
            //string[] arr1 = { "dab", "add", "cab", "fad", "fee", "bad", "dad", "bee", "fed", "bed", "ebb", "ace" };
            //new MSDRadixSort().Sort(arr1);
            //Console.WriteLine(string.Join(":", arr1));

            ////13. 3 way radix+quick sort
            //string[] arr2 = { "dab", "add", "cab", "fad", "fee", "bad", "dad", "bee", "fed", "bed", "ebb", "ace" };
            //new _3WayRadixQuickSort().Sort(arr2);
            //Console.WriteLine(string.Join(":", arr2));

            //LenaSort ls = new LenaSort();
            //ls.ConstructArray(1, 100000, 675013257);

            //BubbleSort.countSwaps(new int[] { 3, 2, 1 });
            //int[] a = new int[] { 2716485, 47574329, 54317443, 73887797, 4690442, 50158330, 36082844, 35504863, 10098449, 36757751, 51223808, 70905600, 2915719, 19449463, 15531534, 90627969, 10138256, 56422983, 94058705, 61663313, 49377065, 49952346, 67204721, 50973358, 35007152, 35561646, 21839119, 62717102, 25604425, 42393960, 26469586, 28320910, 89968289, 33303381, 54725059, 94658731, 83461711, 90807903, 82679946, 46076512, 80082006, 33903754, 69498465, 82997725, 5869569, 85029999, 73625694, 16007825, 41452983, 20200751, 77671138, 43346400, 70153097, 44875859, 46836111, 57676602, 32953858, 68675230, 20393704, 11074635, 63585542, 99379642, 91911897, 6070183, 85199375, 46636956, 53245266, 21177439, 37444859, 35925213, 19770303, 70043217, 69828967, 89268768, 53040943, 75698537, 74298768, 79182989, 44222714, 68268103, 51900093, 21893853, 64130855, 22053190, 19286064, 10966966, 32246144, 52239922, 32158548, 5156201, 15830909, 48260442, 57052195, 7742806, 54330625, 42251571, 54379762, 7575892, 15945362, 44340973, 96017457, 35715665, 14384191, 65846424, 77500786, 19941486, 94061313, 4315906, 51640827, 38284028, 72584009, 3540920, 12694233, 89231216, 78110463, 31980297, 52714535, 10356607, 36736572, 84873083, 68029160, 52567481, 85649878, 25081356, 60310288, 39980503, 19849279, 67206402, 72747, 88310993, 11547376, 96090204, 76543010, 78447919, 14452981, 54043796, 50905757, 8514294, 58359702, 2546584, 99314674, 83460063, 6087505, 12008907, 72691280, 84197968, 96505557, 25405815, 47070927, 85758481, 62795250, 67616440, 90842314, 961480, 92697796, 3668954, 40941984, 65063427, 70875357, 93531083, 53374420, 34939085, 89621288, 29917430, 65903356, 4074269, 36477579, 16809113, 65104915, 94837281, 19355697, 16935942, 78297345, 77959554, 81461201, 3504977, 14673874, 77966758, 81427144, 61744802, 16241591, 96738746, 81877594, 7083906, 97700227, 74575390, 10752860, 91158563, 92155169, 81628217, 84689646, 45529589, 69083654, 26827286, 27963371, 34987010, 83417907, 64440950, 51796123, 823 };
            //Console.WriteLine(MarkAndToys.maximumToys(a, 80000000));

            var a = Comparator.countInversions(new int[] { 7, 5, 3, 1 });
            Console.WriteLine(a);

            Console.Read();
        }


    }
}
