using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class third
    {
        static int[] CompareArrays(int[] input1, int[] input2)
        {
            if (input1.Any(x => x < 0) || input2.Any(x => x < 0))
            {
                return new int[] { -1 };
            }
            if (input1.Length != input2.Length)
            {
                return new int[] { -2 };
            }
            int[] output = new int[input1.Length];
            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Max(input1[i], input2[i]);
            }

            return output;
        }

        static void Main()
        {
            int[] input1 = { 1, 5, 3, 7, 9 };
            int[] input2 = { 2, 4, 6, 1, 10 };
            int[] result = CompareArrays(input1, input2);
            Console.WriteLine("Output: " + string.Join(", ", result));
        }
    }
}

