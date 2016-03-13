using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class ShellSort
    {
        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            DateTime before = DateTime.Now;
            int step = array.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (array.Length - step); i++)
                {
                    int j = i;
                    while (j >= 0 && array[j] > array[j + step])
                    {
                        Swap.Exchange(ref array[j], ref array[j + step]);
                        j--;
                    }
                }
                step = step / 2;
            }
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
