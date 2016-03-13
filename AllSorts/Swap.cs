using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSorts
{
    class Swap
    {
        public static void Exchange(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
    }
}
