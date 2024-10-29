using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;

    class UserProgramCode3
    {
        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reversed = reversed * 10 + remainder;
                number /= 10;
            }
            return reversed;
        }
    }

    class ReverseProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int reversedNumber = UserProgramCode3.ReverseNumber(inputNumber);
            Console.WriteLine("Reversed Number: " + reversedNumber);
        }
    }

}
