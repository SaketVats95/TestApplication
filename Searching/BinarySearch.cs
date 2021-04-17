using System;

namespace Searching
{
    public class BinarySearch
    {
        public static int Iterative(int[] array, int datatoFind)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            while (minIndex <= maxIndex) {
                int midIndex = (minIndex + maxIndex) / 2;
                if (datatoFind == array[midIndex])
                {
                    return ++midIndex;
                }
                else if (datatoFind < array[midIndex])
                {
                    maxIndex = midIndex - 1;
                }
                else {
                    minIndex = midIndex + 1;
                }

            }
            return -1;

        }

        public static int Recursive(int[] array, int datatoFind, int minIndex, int maxIndex)
        {
            int midIndex = (maxIndex + minIndex) / 2;

            if (minIndex > maxIndex)
                return -1;
            else
            {
                if (datatoFind == array[midIndex])
                    return midIndex;

                if (datatoFind < array[midIndex])
                    return Recursive(array, datatoFind, minIndex, midIndex - 1);
                else
                    return Recursive(array, datatoFind, midIndex + 1, maxIndex);
            }
        }
    }
}
