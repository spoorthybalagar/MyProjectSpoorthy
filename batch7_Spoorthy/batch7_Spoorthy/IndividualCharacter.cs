using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class IndividualCharacter
    {

        static void Main(string[] args)
        {
            string inputString = "Hello World!";
            Console.WriteLine("Individual characters in the string:");

            foreach (char c in inputString)
            {
                Console.Write(c+" ");
            }
        }
    }

}

