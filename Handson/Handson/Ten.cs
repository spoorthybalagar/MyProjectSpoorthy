using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Ten
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 12, 34, 56, 17, 2 }; 
            int inputSize = 5; 
            int[] outputArray = ProcessArray(inputArray, inputSize);
            Console.WriteLine("Output Array: " + string.Join(", ", outputArray));
        }

        static int[] ProcessArray(int[] arr, int size)
        {
            
            if (size < 0)
            {
                return new int[] { -2 };
            }
            foreach (var number in arr)
            {
                if (number < 0)
                {
                    return new int[] { -1 };
                }
            }
            if (size % 2 == 0)
            {
                return new int[] { -3 };
            }
            int[] output = new int[size];
            Array.Copy(arr, output, size);
            for (int i = 0; i < size / 2; i++)
            {
                int temp = output[i];
                output[i] = output[size - 1 - i];
                output[size - 1 - i] = temp;
            }
            int first = output[0];
            output[0] = output[size - 1];
            output[size - 1] = first;

            return output;
        }
    }
}
