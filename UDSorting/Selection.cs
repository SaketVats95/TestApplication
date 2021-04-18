using System;

namespace UDSorting
{
    public class Selection
    {
        public static void Sort(int[] array) {
            int length = array.Length;
            
            for (int j = 0; j < length - 1; j++)
            {
                int minIndex = j;

                for (int i = j+1; i < length; i++)
                {
                    if (array[i] < array[minIndex])
                    {
                        minIndex = i;

                    }
                }
                int temp = array[j];
                array[j] = array[minIndex];
                array[minIndex] = temp;
            }

            Console.WriteLine($" Sorted Data : {String.Join(",",array)}");

        }

        
    }
}
