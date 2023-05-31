using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming6
{
    internal class Revers
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine()); // The number you want to reverse
            int reverse = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }

            Console.WriteLine("Reversed number: " + reverse);
        }
    }
}

