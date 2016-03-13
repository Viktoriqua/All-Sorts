using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSortsTest
{
    class CheckArray
    {
        public static bool CheckForSortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) return false;
            }
            return true;
        }
    }
}
