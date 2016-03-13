using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class HeapSort
    {
        private static void Heapify(int[] array, int parent, int currentIndex)
        {
            while (2 * parent + 1 < currentIndex)
            {
                int temp = 2 * parent + 1;
                if (2 * parent + 2 < currentIndex && array[2 * parent + 2] >= array[temp])
                {
                    temp = 2 * parent + 2;
                }
                if (array[parent] < array[temp])
                {
                    Swap.Exchange(ref array[parent], ref array[temp]);
                    parent = temp;
                }
                else break;
            }
        }

        private static void HeapMake(int[] array,int currentIndex)
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                Heapify(array, i, currentIndex);
            }
        }

        public static TimeSpan Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            DateTime before = DateTime.Now;
            int currentIndex = array.Length;
            HeapMake(array, currentIndex);
            while (currentIndex > 0)
            {
                Swap.Exchange(ref array[0], ref array[currentIndex - 1]);
                currentIndex--;
                Heapify(array, 0, currentIndex);
            }
            DateTime after = DateTime.Now;
            return after - before;
        }
    }
}
