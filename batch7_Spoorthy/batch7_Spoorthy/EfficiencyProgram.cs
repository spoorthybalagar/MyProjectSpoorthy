using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;

    class UserProgramCode2
    {
        public static string EfficiencyChecker(float timeTaken)
        {
            if (timeTaken >= 1 && timeTaken <= 3)
            {
                return "Highly efficient";
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                return "Improve speed";
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                return "Need Training";
            }
            else if (timeTaken > 5)
            {
                return "Leave the company";
            }
            else
            {
                return "Invalid Input";
            }
        }
    }

    class EfficiencyProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time taken by worker: ");
            float timeTaken = float.Parse(Console.ReadLine());

            string result = UserProgramCode2.EfficiencyChecker(timeTaken);
            Console.WriteLine(result);
        }
    }

}
