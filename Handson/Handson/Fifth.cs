using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Fifth
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 }; 
            int target = 30; 
            int output = SearchElement(arr, arr.Length, target);

            Console.WriteLine($"Output: {output}");
        }

        static int SearchElement(int[] arr, int size, int target)
        {
            int output = 0;
            if (size < 0)
            {
                output = -2;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] < 0)
                    {
                        output = -1;
                        return output; 
                    }
                }
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] == target)
                    {
                        output = i;
                        return output; 
                    }
                }

                output = 1; 
            }

            return output;
        }
    }
}
