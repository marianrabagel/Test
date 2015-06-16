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
            for (int i = 0; i < array.Length; i++)
                if (isEven(array[i]))
                    addToSum(array[i]);
            return s;
        }
        private bool isEven(int number)
        {
            if(number % 2 == 0)
                return true;
            return false;
        }
        private void addToSum(int number)
        {
            s += number;
        }
    }
}
