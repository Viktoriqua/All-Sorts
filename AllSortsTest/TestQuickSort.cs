using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AllSorts;

namespace AllSortsTest
{
    [TestFixture]
    class TestQuickSort
    {
        bool result;
        [Test]
        public void CheckOneElementArray()
        {
            int[] array = { 7 };
            int[] expResult = { 7 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }
        [Test]
        public void CheckTenElementArray()
        {
            int[] array = { 12, 25, 16, 89, 13, 5, 7, 3, 17, 10 };
            int[] expResult = { 3, 5, 7, 10, 12, 13, 16, 17, 25, 89 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }
        [Test]
        public void CheckNegativeValues()
        {
            int[] array = { -25, -8, -17, -43 };
            int[] expResult = { -43, -25, -17, -8 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }
        [Test]
        public void CheckPositiveAndNegativeValues()
        {
            int[] array = { -25, -6, 13, -95, 17, 236 };
            int[] expResult = { -95, -25, -6, 13, 17, 236 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }
        [Test]
        public void CheckBigValues()
        {
            int[] array = { 25692, -16859, 154999 };
            int[] expResult = { -16859, 25692, 154999 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }
        [Test]
        public void CheckEqualValues()
        {
            int[] array = { 6, 6, 6, 1, 6, 6, 6, 25, 6, 6 };
            int[] expResult = { 1, 6, 6, 6, 6, 6, 6, 6, 6, 25 };
            AllSorts.QuickSort.Sort(array);
            result = true;
            bool curResult = ArrayCompare.CheckArrays(array, expResult);
            Assert.AreEqual(curResult, result);
        }

        public int[] array { get; set; }

        [Test]
        public void Check100RandomArrays()
        {
            bool result = true;
            Random random = new Random();
            for (int j = 0; j < 100; j++)
            {
                int size = random.Next();
                int[] arrayForSort = new int[size];
                AllSorts.ArrayCreator.RandomArray(array, size);
                AllSorts.BubbleSort.Sort(arrayForSort);
                if (!CheckArray.CheckForSortArray(array))
                {
                    result = false;
                    break;
                }
            }
            bool expResult = true;
            Assert.AreEqual(expResult, result);
        }
    }
}
