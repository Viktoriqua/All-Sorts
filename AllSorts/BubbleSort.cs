using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class BubbleSort
    {
        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            DateTime before = DateTime.Now;
            for (int j = 0; j <= array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap.Exchange(ref array[i], ref array[i + 1]);
                    }
                }
            }
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
