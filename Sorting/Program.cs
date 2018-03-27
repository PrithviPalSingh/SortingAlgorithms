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

            //1.Insertion sort
            InsertionSort ins = new InsertionSort();
            int[] items = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            ins.Sort(items);

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
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //insertionSort2(n, arr);

            //5. Selection sort
            SelectionSort ss = new SelectionSort();
            int[] items1 = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            ss.Sort(items1);

            Console.Read();
        }       

       
    }
}
