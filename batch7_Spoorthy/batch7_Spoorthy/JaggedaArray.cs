using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class JaggedaArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 20, 15, 35, 40, 25 };
            arr[1] = new int[] { 90, 75, 30, 45 };
            arr[2] = new int[] { 70, 60, 10, 80, 35 };
            Console.WriteLine("elements of arr are:");
            foreach (int[] i in arr)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
