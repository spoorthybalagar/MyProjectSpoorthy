using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Nine
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, 5 }; 
            int inputSize = 5; 
            int output = SumOfPrimes(inputArray, inputSize);
            Console.WriteLine($"Output: {output}");
        }

        static int SumOfPrimes(int[] arr, int size)
        {
            if (size < 0)
            {
                return -2;
            }
            foreach (var number in arr)
            {
                if (number < 0)
                {
                    return -1;
                }
            }
            int sum = 0;
            bool hasPrime = false;
            foreach (var number in arr)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    hasPrime = true;
                }
            }
            if (!hasPrime)
            {
                return -3;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

