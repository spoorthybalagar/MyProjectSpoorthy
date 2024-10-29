using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    class StringArray
    {

        static void Main(string[] args)
        {
            string[] strArray = { "apple", "banana", "apple", "orange", "banana", "grape", "apple" };
            bool[] visited = new bool[strArray.Length]; 
            Console.WriteLine("Repeated elements are:");
            for (int i = 0; i < strArray.Length; i++)
            {
                if (visited[i])  
                    continue;
               int count = 1; 
                for (int j = i + 1; j < strArray.Length; j++)
                {
                    if (strArray[i] == strArray[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(strArray[i] + ": " + count + " times");
                }
            
        }
    }

}
}
