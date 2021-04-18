using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDSorting
{
    public class BubbleSort
    {
        public static void Sort(int[] array) {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int flag = 0;
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = 1;
                    }
                }
                if (flag == 0) break;

            }

            Console.WriteLine($"Sorted Data : {String.Join(",", array)}");
        }
    }
}
