using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgileFreaks_test1;
namespace SumOfEvenNumbersUnitTest
{
    [TestClass]
    
    public class ArrayDuplicatesUnitTest
    {
        [TestMethod]
        public void EmptyArray()
        {
            int[] array = {};
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(false, ad.hasDuplicates(array));
        }
        [TestMethod]
        public void NoDuplicates()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(false, ad.hasDuplicates(array));            
        }
        [TestMethod]
        public void OneElement()
        {
            int[] array2 = { 1 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(false, ad.hasDuplicates(array2));
        }
        [TestMethod]
        public void DuplicateCase1()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 1 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(true, ad.hasDuplicates(array1));
        }
        [TestMethod]
        public void AllDuplicates()
        {
            int[] array3 = { 1, 1, 1, 1, 1, 1, 1 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(true, ad.hasDuplicates(array3));
        }
        [TestMethod]
        public void DuplicateCase2()
        {
            int[] array4 = { 1, 2, 2, 2, 3, 4, 3, 5 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(true, ad.hasDuplicates(array4));
        }
        [TestMethod]
        public void DuplicateCase3()
        {
            int[] array5 = { 1, 2, 3, 4, 1 };
            ArrayDuplicates ad = new ArrayDuplicates();

            Assert.AreEqual(true ,ad.hasDuplicates(array5));
        }

    }
}
