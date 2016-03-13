using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    public class ArrayCreator
    {
        public static void RandomArray(int[] array, int arraySize)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (arraySize <= 0 || arraySize >int.MaxValue)
            {
                throw new ArgumentNullException("arraySize");
            }
            const int maxValue = 1000;
            Random randomElement = new Random();
            for (int i = 0; i <= arraySize - 1; i++)
            {
                array[i] = randomElement.Next(maxValue);
            }
            Console.Write("Your array for sort: ");
            for (int i = 0; i <= arraySize - 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        private static int ElementReader(int i)
        {
            while (true)
            {
                int elementArray;
                Console.WriteLine("Please enter {0} array element", i+1);
                string element = Console.ReadLine();
                if (int.TryParse(element, out elementArray))
                {
                    return elementArray;
                }
            }
        }

        public static void CreateArray(int[] array, int arraySize)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (arraySize <= 0 || arraySize > int.MaxValue)
            {
                throw new ArgumentNullException("arraySize");
            }
            for (int i = 0; i <= arraySize - 1; i++)
            {
                array[i] = ElementReader(i);
            }
            Console.Write("Your array for sort: ");
            for (int i = 0; i <= arraySize - 1; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
        }
    }
}
