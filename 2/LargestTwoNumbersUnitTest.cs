using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileFreaks_test1;
namespace SumOfEvenNumbersUnitTest
{
    [TestClass]
    public class LargestTwoNumbersUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void EmptyArray() {
            int[] EmptyArray = { };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(EmptyArray);

            Assert.AreEqual(int.MinValue, ltn.getMax());
            Assert.AreEqual(int.MinValue, ltn.getSecondMax());
        }
        [TestMethod]
        public void OneElement()
        {
            int[] array = { 5};
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array);
            Assert.AreEqual(5, ltn.getMax());
            Assert.AreEqual(int.MinValue, ltn.getSecondMax());
        }
        [TestMethod]
        public void MaxAndSecondMaxCase1()
        {
            int[] array = { 1, 2, 3 };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array);

            Assert.AreEqual(3, ltn.getMax());
            Assert.AreEqual(2, ltn.getSecondMax());

        }
        public void MaxAndSecondMaxCase2()
        {
            int[] array2 = { 7, 1, 2, 3, 4, 5 };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array2);

            Assert.AreEqual(7, ltn.getMax());
            Assert.AreEqual(5, ltn.getSecondMax());
        }
        public void MaxAndSecondMaxCase3()
        {
            int[] array3 = { 6, 7, 2, 3, 4, 5 };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array3);

            Assert.AreEqual(7, ltn.getMax());
            Assert.AreEqual(6, ltn.getSecondMax());
        }
        [TestMethod]
        public void MaxAndSecondMaxCase4()
        {
            int[] array3 = { 1, 2, 2 };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array3);

            Assert.AreEqual(2, ltn.getMax());
            Assert.AreEqual(1, ltn.getSecondMax());
        }

        [TestMethod]
        public void AllSameValue()
        {
            int[] array = { 1, 1, 1, 1, 1 };
            LargestTwoNumbers ltn = new LargestTwoNumbers();
            ltn.setMaxAndSecondMax(array);

            Assert.AreEqual(1, ltn.getMax());
            Assert.AreEqual(int.MinValue, ltn.getSecondMax());
        }
    }
}
