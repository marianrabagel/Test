using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileFreaks_test1;

namespace SumOfEvenNumbersUnitTest
{
    [TestClass]
    public class SumOfEvenNumbersTest
    {
        [TestMethod]
        public void EmptyArray()
        {
            int[] array = {} ;

            SumOfEvenNumbers soen = new SumOfEvenNumbers();
            int sum = soen.computeEvenNumbersSum(array);

            Assert.AreEqual(0, sum, "Sum is incorrect.Asserrtion test failed");

        }
        [TestMethod]
        public void EvenNumersSum()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            
            SumOfEvenNumbers soen = new SumOfEvenNumbers();
            int sum = soen.computeEvenNumbersSum(array);

            Assert.AreEqual(20, sum,"Sum is incorrect.Asserrtion test failed");
        }
        [TestMethod]
        public void NoEvenNumbers()
        {
            int[] array = { 1, 3, 5, 7 };

            SumOfEvenNumbers soen = new SumOfEvenNumbers();
            int sum = soen.computeEvenNumbersSum(array);

            Assert.AreEqual(0, sum, "Sum is incorrect.Asserrtion test failed");
        }
    }
}
