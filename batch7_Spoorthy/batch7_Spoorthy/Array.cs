using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class changeSizeOfArrAtRunTime
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 50, 10, 40, 60, 20, 30 };
            Console.WriteLine("elements of array are:");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\n enter the new size of array");
            int s=Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, s);
            Console.WriteLine("elements of new size array");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
