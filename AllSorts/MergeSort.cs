using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class MergeSort
    {
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

        private static void Sort(int[] array, int left, int rigth)
        {
            if (left >= rigth) return;
            int currentArrayLength = (left + rigth) / 2;
            Sort(array, left, currentArrayLength);
            Sort(array, currentArrayLength + 1, rigth);
            Merge(array, left, currentArrayLength, rigth);
        }

        private static void Merge(int[] array, int left, int currentArrayLength, int rigth)
        {
            if (currentArrayLength + 1 > rigth) return;

            int[] bufferArray = new int[array.Length];

            for (int i = left; i <= currentArrayLength; i++)
            {
                bufferArray[i] = array[i];
            }

            for (int i = currentArrayLength + 1; i <= rigth; i++)
            {
                bufferArray[i] = array[rigth + currentArrayLength + 1 - i];
            }

            int currentLeft = left; int currentRight = rigth;
            for (int i = left; i <= rigth; i++)
            {
                if (bufferArray[currentLeft] >= bufferArray[currentRight])
                {
                    array[i] = bufferArray[currentLeft];
                    currentLeft++;
                }
                else
                {
                    array[i] = bufferArray[currentRight];
                    currentRight--;
                }
            }
        }
    }
}
