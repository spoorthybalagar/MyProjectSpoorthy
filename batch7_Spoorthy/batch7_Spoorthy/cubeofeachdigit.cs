using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class cubeofeachdigit
    {
       
        static void Main()
        {
            int[] numArray = { 123, 456, 789 };

            int sum = 0;
            foreach (int num in numArray)
            {
                int temp = num;

                while (temp != 0)
                {
                    int digit = temp % 10;  
                    sum += digit * digit * digit;  
                    temp /= 10;  
                }
            }

            Console.WriteLine("The sum of the cubes of the digits is: " + sum);
        }
    }

}

