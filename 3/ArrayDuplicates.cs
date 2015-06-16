using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_test1
{
    public class ArrayDuplicates
    {
        public bool hasDuplicates(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[array[i] % array.Length] > array.Length)
                    return true;
                else
                    array[array[i] % array.Length] += array.Length;
            }
            return false;
        }
    }
}
