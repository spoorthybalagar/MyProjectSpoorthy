using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Fourth
    {
        static int SumOfEvenDigits(int number)
        { 
            if (number < 0)
            {
                return -1;
            }
            if (number > 32767)
            {
                return -2;
            }

            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = SumOfEvenDigits(number);
            Console.WriteLine("Sum of even digits: " + result);
        }
    
}
}
