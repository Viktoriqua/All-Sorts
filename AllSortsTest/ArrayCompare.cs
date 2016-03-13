using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSortsTest
{
    class ArrayCompare
    {
        public static bool CheckArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null)
            {
                throw new ArgumentNullException("firstArray");
            }
            if (secondArray == null)
            {
                throw new ArgumentNullException("secondArray");
            }

            for (int i = 0; i < firstArray.Length - 1; i++)
            {
                if (firstArray[i] != secondArray[i]) return false;
            }
            return true;
        }
    }
}
