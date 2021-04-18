using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDSorting
{
    public class Insertion
    {
        public static void Sort(int[] array) {
            int length = array.Length;

            for (int j = 1; j <= length - 1; j++)
            {
                int hole = j;
                int value = array[j];
                while(hole > 0 && array[hole -1] > value)
                //for (int i = hole-1; i >= 0; i--)
                {
                        array[hole] = array[hole - 1];
                        hole = hole-1;
                }
                array[hole] = value;
            }
            Console.WriteLine($"Sorted Data : {String.Join(",", array)}");


        }
    }
}
