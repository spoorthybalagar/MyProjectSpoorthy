using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class ArrayMethod
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[6] { 50, 10, 40, 60, 20, 30 };
            int[] arrB = new int[12] { 15, 25, 35, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("elements of arrA are:");
            foreach (int i in arrA)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nelements of arrB are:");
            foreach (int i in arrB)
            {
                Console.WriteLine(i + " ");
            }
            Array.Copy(arrA, 0, arrB, 3, 6);
            Console.WriteLine("\n elements of arrB after copying");
            foreach (int i in arrB)
            {
                Console.WriteLine(i + " ");
            }
            Array.Reverse(arrA);
            Console.WriteLine("\n elements of arrA after reversing");
            foreach (int i in arrA)
            {
                Console.WriteLine(i + " ");
            }
            Array.Sort(arrA);
            Console.WriteLine("\n elements of arrA after sort");
            foreach (int i in arrA)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("enter the search elements");
            int s=int.Parse(Console.ReadLine());
            int F=Array.BinarySearch(arrA, s);
            if (F >= 0)
            {
                Console.WriteLine("search element found in{0} location", (F + 1));
            }
            else
            {
                Console.WriteLine("search element is not found");
            }
            Array.Clear(arrA,2,3);
            Console.WriteLine("elements of arrA after clearing");
            foreach (int i in arrA)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
