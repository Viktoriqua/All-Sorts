using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    class ChoiceSort
    {
        public static int ChoiceReader(int userChoice)
        {
                Console.WriteLine("Please choose which method of sorts you want to use and enter the appropriate number");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Insert Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Heap Sort");
                Console.WriteLine("5. Shell Sort");
                Console.WriteLine("6. Quick Sort");
                Console.WriteLine("7. Merge Sort");
                Console.WriteLine("8. All sorts together");
                int userAnswer;
                bool right = true;
                while (right)
                {
                    Console.WriteLine("Now please enter the appropriate number:");
                    string Read = Console.ReadLine();
                    if (int.TryParse(Read, out userAnswer) && userAnswer > 0 && userAnswer < 10)
                    {
                        userChoice = userAnswer;
                        right = false;
                    }
                }
                return userChoice;
        }
    }
}
