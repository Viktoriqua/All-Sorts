using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class InsertSort
    {
        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            DateTime before = DateTime.Now;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
