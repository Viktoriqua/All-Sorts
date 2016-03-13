using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class SelectionSort
    {
        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            DateTime before = DateTime.Now;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMinElement = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexMinElement])
                    {
                        indexMinElement = j;
                    }
                }
                if (indexMinElement != i)
                {
                    Swap.Exchange(ref array[i], ref array[indexMinElement]);
                }
            }
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
