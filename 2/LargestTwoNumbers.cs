using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileFreaks_test1
{
    public class LargestTwoNumbers
    {
        private int max, secondMax;
        public LargestTwoNumbers(){
            max = secondMax = int.MinValue;
        }
        public int getMax() { return max; }
        public int getSecondMax() { return secondMax; }
        public void setMaxAndSecondMax(int[] array)
        {
            if (hasOneElement(array.Length))
                max = array[0];
            else
            {
                initializeMaxAndSecondMaxWIthFirstTwoElements(array[0], array[1]);
                saveMaxAndSecondMax(array);
                checkMaxAndSecondMaxEquality();
            }
        }

        private void checkMaxAndSecondMaxEquality()
        {
            if (areEqual())
                secondMax = int.MinValue;
        }
        private bool areEqual()
        {
            return secondMax == max;
        }
        private void saveMaxAndSecondMax(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (isMax(array[i])){
                    secondMax = max;
                    max = array[i];
                }
                if (isSecondMax(array[i]))
                    secondMax = array[i];
            }
        }
        private void initializeMaxAndSecondMaxWIthFirstTwoElements(int firstElement, int secondElement)
        {
            if (isFirstGreater(firstElement, secondElement))
            {
                max = firstElement;
                secondMax = secondElement;
            }
            else{
                max = secondElement;
                secondMax = firstElement;
            }
        }

        private static bool isFirstGreater(int firstElement, int secondElement)
        {
            return firstElement > secondElement;
        }
        private static bool hasOneElement(int length)
        {
            return length < 2;
        }
        private bool isSecondMax(int number)
        {
            return (number < max) && (number > secondMax);
        }
        private bool isMax(int number)
        {
            return number > max;
        }
        private bool isNull(int[] array)
        {
            return array == null;
        }
    }
}
