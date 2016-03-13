using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class QuickSort
    {
        private static void Sort(int[] array, int left, int right)
        {
            int currentLeft = left;
            int currentRigth = right;

            if (left < right)
            {
                int landmarkElement = array[(left + right) / 2];
                while (currentLeft <= currentRigth)
                {
                    while (currentLeft < right && array[currentLeft] < landmarkElement)
                    {
                        currentLeft++;
                    }
                    while (currentRigth > left && array[currentRigth] > landmarkElement)
                    {
                        currentRigth--;
                    }

                    if (currentLeft <= currentRigth)
                    {
                        Swap.Exchange(ref array[currentLeft], ref array[currentRigth]);
                        currentLeft++;
                        currentRigth--;
                    }
                }

                if (currentRigth - left >= 1) Sort(array, left, currentRigth);
                if (right - currentLeft >= 1) Sort(array, currentLeft, right);

            }
        }

        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            DateTime before = DateTime.Now;
            Sort(array, 0, array.Length - 1);
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
