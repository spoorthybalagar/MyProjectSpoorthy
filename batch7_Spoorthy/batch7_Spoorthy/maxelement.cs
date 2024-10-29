using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class Maxelement
    {
        static void Main(string[]args)
        {
            int[] numArray = { 12, 45, 23, 89, 55, 67, 34, 99, 76, 11 };
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            //int thirdMax = int.MinValue;
            int min1 = int.MaxValue;
            int min2 = int.MinValue;
            foreach (int num in numArray)
            {
                if (num > firstMax)
                {
                    //thirdMax = secondMax;   
                    secondMax = firstMax;   
                    firstMax = num;         
                }
                else if (num > secondMax)
                {
                    //thirdMax = secondMax;   
                    secondMax = num;       
                }
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                {
                    min2 = num;
                }
                    
                //else if (num > thirdMax)
                //{
                //    thirdMax = num;      
                //}
            }
            Console.WriteLine("The two largest and smallest elements are: ");
            Console.WriteLine("First max: " + firstMax);
            Console.WriteLine("Second max: " + secondMax);
            //Console.WriteLine("Third max: " + thirdMax);
            Console.WriteLine("first min: " +min1);
            Console.WriteLine("Second min: " + min2);
        }
    }

}

