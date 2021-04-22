using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDSorting
{
    public class Quick
    {
        public static void Sort(int[] array) {
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine($"Sorted Data : {String.Join(",", array)}");
        }
        public static void QuickSort(int[] array,int start,int end)
        {
            if (start >= end)
                return;
            int pIndex = Partition( array, start, end);
            QuickSort(array, start, pIndex - 1);
            QuickSort(array, pIndex + 1, end);
        }

        private static int Partition(int[] array, int start, int end)
        {
            int pivot = array[start];
            int i = start;
            int j = end;
            while (i <= j)
            {
                do { i++; } while (i <=end && array[i] <= pivot);
                //do { j--; } while (j >= start && array[j] > pivot);
                while (j >= start && array[j] > pivot) { j--; };
                if (i <= j) {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            array[start] = array[j];
            array[j] = pivot;
            return j;
        }
    }
}
