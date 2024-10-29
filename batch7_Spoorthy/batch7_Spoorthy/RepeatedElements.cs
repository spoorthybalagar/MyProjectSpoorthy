using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class RepeatedElements
    {
       
        static void Main()
        { 
            int[] numArray = { 12, 45, 12, 89, 45, 67, 34, 89, 76, 12 };
            //bool[] visited = new bool[numArray.Length];
            Array.Sort(numArray);

            Console.WriteLine("Repeated elements:");
            bool hasduplicate = false;
            for (int i = 1; i < numArray.Length; i++)
            {
                //if (visited[i]) 
                //    continue;

                //int count = 1;
                //for (int j = i + 1; j < numArray.Length; j++)
                //{
                //    if (numArray[i] == numArray[j])
                //    {
                //        count++;
                //        visited[j] = true;
                //    }
                //}
                if (numArray[i] == numArray[i-1])
                {
                    Console.WriteLine(numArray[i] + " is repeated " );
                    hasduplicate = true;
                }
            }
            if (!hasduplicate)
            {
                Console.WriteLine(" no Repeated elements");
            }
        }
    }

}

