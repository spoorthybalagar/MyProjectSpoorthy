using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Seven
    {
        static void Main(string[] args)
        { 
            int[] input1 = { 1, 2, 3, 4, 5, 6 };
            int input2 = 6; 
            int output = CountMultiplesOfThree(input1, input2);            Console.WriteLine($"Output: {output}");
        }

        static int CountMultiplesOfThree(int[] arr, int size)
        { 
            int output = 0;
            if (size < 0)
            {
                return -2;
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    return -1;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    output++;
                }
            }

            return output; 
        }
    }
}
