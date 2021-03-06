﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Efficient for duplicate keys
    /// Partition array into 3 parts:
    ///  1. Entries between LT and GT equal to partitioning element V
    ///  2. No Larger element to left of LT
    ///  3. No gretaer element to right of GT
    /// </summary>
    class Dijkstra3WaySorting
    {
        public void Sort(int[] arr)
        {
            int N = arr.Length - 1;
            Sort(arr, 0, N);
            Utilities.Print(arr);
        }

        private void Sort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int i = low;
            int lt = low;
            int gt = high;

            while (i <= gt)
            {
                if (arr[i] > arr[lt])
                {
                    Utilities.Exchange(arr, i, gt--);                    
                }
                else if (arr[i] < arr[lt])
                {
                    Utilities.Exchange(arr, i++, lt++);
                }
                else
                {
                    i++;
                }
            }

            Sort(arr, low, lt - 1);
            Sort(arr, gt + 1, high);
        }
    }
}
