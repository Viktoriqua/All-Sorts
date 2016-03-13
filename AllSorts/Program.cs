using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    class Program
    {
        private static int ArraySize()
        {
            int arraySize;
            while (true)
            {
                Console.WriteLine("Please enter the number of elements in the proposed array:");
                string forRead = Console.ReadLine();
                if (int.TryParse(forRead, out arraySize) && arraySize > 0)
                {
                    return arraySize;
                }
            }
        }

        static void Main(string[] args)
        {
            string userAnswer;
            Console.WriteLine("This program sorts the array by method which you choose, and let you know runtime and result of sorting.");
            while (true)
            {
                Console.WriteLine("Do you want to use a random array or create it yourself. (r/c)");
                userAnswer = Console.ReadLine().ToUpper();
                if (string.Equals(userAnswer, "R") || string.Equals(userAnswer, "C"))
                {
                    break;
                }
            }

            int arraySize = ArraySize();
            int[] array = new int[arraySize];

            if (string.Equals(userAnswer, "C"))
            {
                ArrayCreator.CreateArray(array, array.Length);
            }
            else
            {
                ArrayCreator.RandomArray(array, array.Length);
            }
            int userChoice = 0;
            userChoice = ChoiceSort.ChoiceReader(userChoice);
            switch (userChoice)
            {
                case 1:
                    TimeSpan time1 = BubbleSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Bubble sort method is {0}", time1);
                    break;
                case 2:
                    TimeSpan time2 = InsertSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Insert sort method is {0}", time2);
                    break;
                case 3:
                    TimeSpan time3 = SelectionSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Selection sort method is {0}", time3);
                    break;
                case 4:
                    TimeSpan time4 = HeapSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Heap sort method is {0}", time4);
                    break;
                case 5:
                    TimeSpan time5 = ShellSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Shell sort method is {0}", time5);
                    break;
                case 6:
                    TimeSpan time6 = QuickSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Quick sort method is {0}", time6);
                    break;
                case 7:
                    TimeSpan time7 = MergeSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Merge sort method is {0}", time7);
                    break;
                case 8:
                    TimeSpan time = QuickSort.Sort(array);
                    Console.Write("Sorted array: ");
                    ArrayWriter.Writer(array);
                    Console.WriteLine("Time spent on sorting the array by Quick sort method is {0}", time);
                    Console.WriteLine("Time spent on sorting the array by Bubble sort method is {0}", BubbleSort.Sort(array));
                    Console.WriteLine("Time spent on sorting the array by Insert sort method is {0}", InsertSort.Sort(array));
                    Console.WriteLine("Time spent on sorting the array by Selection sort method is {0}", SelectionSort.Sort(array));
                    Console.WriteLine("Time spent on sorting the array by Heap sort method is {0}", HeapSort.Sort(array));
                    Console.WriteLine("Time spent on sorting the array by Shell sort method is {0}", ShellSort.Sort(array));
                    Console.WriteLine("Time spent on sorting the array by Merge sort method is {0}", MergeSort.Sort(array));
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
