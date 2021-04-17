using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class LinearSearch
    {
        public static int Normal(int[] array, int dataToFind) 
        {
            for(int i= 0; i< array.Length; i++)
            {
                if (dataToFind == array[i])
                    return ++i;
            }
            return -1;
        }
    }
}
