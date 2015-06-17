using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_test1
{
    public class SumOfEvenNumbers
    {
        private int s;

        public SumOfEvenNumbers()
        {
            s = 0;
        }

        public int computeEvenNumbersSum(int[] array)
        {
            s = 0;
            for (int i = 0; i < array.Length; i++)
                if (isEven(array[i]))
                    addToSum(array[i]);
            return s;
        }
        private bool isEven(int number)
        {
            return number % 2 == 0;
                
        }
        private void addToSum(int number)
        {
            s += number;
        }
    }
}
