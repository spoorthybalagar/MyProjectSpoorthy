using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    

class UserProgramCode
    {
        public static int sumOfDigits(string[] input1)
        {
            int Sum = 0;
            foreach (string str in input1)
            {
                foreach (char ch in str)
                {
                    if (!Char.IsLetterOrDigit(ch))
                    {
                        return -1;
                    }
                    if (Char.IsDigit(ch))
                    {
                       Sum += (int)Char.GetNumericValue(ch);
                    }
                }
            }
            return Sum;
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputArray[i] = Console.ReadLine();
            }
            int result = UserProgramCode.sumOfDigits(inputArray);
            Console.WriteLine(result);
        }
    }

}

