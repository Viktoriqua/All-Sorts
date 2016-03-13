using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    class ArrayWriter
    {
        public static void Writer(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
