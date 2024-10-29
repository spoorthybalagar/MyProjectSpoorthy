using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    internal class Six
    {
        static void Main(string[] args)
        {
            int[] input1 = { 2, 2, 2, 2, 3, 3, 3, 3, 4 };
            int[] input2 = { 2, 2, 2, 3, 3, 4 };
            int[] output1 = GetMostRepeatedElements(input1);
            int[] output2 = GetMostRepeatedElements(input2);
            Console.WriteLine("Output for input1: [" + string.Join(", ", output1) + "]");
            Console.WriteLine("Output for input2: [" + string.Join(", ", output2) + "]");
        }

        static int[] GetMostRepeatedElements(int[] arr)
        {
            int maxCount = 0;
            int maxCountElement = 0; 
            int uniqueCount = 0; 
            int[] tempOutput = new int[arr.Length]; 

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    uniqueCount = 0; 
                    maxCountElement = arr[i]; 
                    tempOutput[uniqueCount++] = arr[i];
                }
                else if (count == maxCount && arr[i] != maxCountElement)
                {
                   
                    tempOutput[uniqueCount++] = arr[i]; 
                }
            }

            
            int[] output = new int[uniqueCount];
            Array.Copy(tempOutput, output, uniqueCount); 

            return output;
        }
    }
}
