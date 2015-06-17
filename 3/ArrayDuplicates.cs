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
                int elementIndex = array[i] % array.Length;
                if (array[elementIndex] > array.Length)
                    return true;
                else
                    array[elementIndex] += array.Length;
            }
            return false;
        }
    }
}
