using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDSorting
{
    public class Merge
    {
        public static void Sort(int[] array) {
            MergeSort(array);
            Console.WriteLine($"Sorted Data : {String.Join(",", array)}");
        }

        public static void MergeSort(int[] array) {
           
            int length = array.Length;
            if (length == 1) { return; }
            int mid = length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[length - mid];
            for (int i = 0; i < mid; i++)
            {
                leftArray[i] = array[i];
            }
            for (int i = mid; i < length; i++)
            {
                rightArray[i - mid] = array[i];
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            MergeArray(leftArray, rightArray, array);
        }

        private static void MergeArray(int[] leftArray, int[] rightArray, int[] array)
        {
            int lenLeft = leftArray.Length;
            int lenRight = rightArray.Length;
            int lC =0, rC =0 , current = 0;
            while (lC < lenLeft && rC < lenRight)
            {
                if (leftArray[lC] < rightArray[rC])
                {
                    array[current] = leftArray[lC];
                    lC = lC + 1;
                }
                else {
                    array[current] = rightArray[rC];
                    rC += 1;
                }
                current += 1;
            }
            while(lC< lenLeft)
            {
                array[current] = leftArray[lC];
                lC = lC + 1;
                current += 1;
            }

            while (rC < lenRight)
            {
                array[current] = rightArray[rC];
                rC += 1;
                current += 1;
            }
        }
    }
}
