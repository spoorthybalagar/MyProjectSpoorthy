using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Eight
    {
        static void Main(string[] args)
        {
            int input1 = 56;
            int output = CalculateProductAndCheckDivisibility(input1);
            Console.WriteLine($"Output: {output}");
        }

        static int CalculateProductAndCheckDivisibility(int number)
        {
            if (number < 0)
            {
                return -1;
            }
            if (number % 3 == 0 || number % 5 == 0)
            {
                return -2;
            }
            int product = 1;
            int temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                product *= digit;
                temp /= 10;
            }
            if (product % 3 == 0 || product % 5 == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
