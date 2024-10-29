using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;

    class UserProgramCodee
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            int n = input1.Length / 2;
            string[] employees = new string[n];  
            int empCount = 0;  
            bool isAllSameDesignation = true;
            string firstDesignation = input1[1].ToLower();  
            string designationToSearch = input2.ToLower();
            for (int i = 0; i < input1.Length; i += 2)
            {
                string employeeName = input1[i];
                string designation = input1[i + 1].ToLower();
                if (HasSpecialCharacters(employeeName) || HasSpecialCharacters(input2))
                {
                    Console.WriteLine("Invalid Input");
                    return new string[0];
                }
                if (designation == designationToSearch)
                {
                    employees[empCount] = employeeName;
                    empCount++;
                }
                if (designation != firstDesignation)
                {
                    isAllSameDesignation = false;
                }
            }
            if (empCount == 0)
            {
                Console.WriteLine($"No employee for {input2} designation");
                return new string[0]; 
            }
            if (isAllSameDesignation && firstDesignation == designationToSearch)
            {
                Console.WriteLine($"All employees belong to same {input2} designation");
                return new string[0]; 
            }
            string[] result = new string[empCount];
            for (int i = 0; i < empCount; i++)
            {
                result[i] = employees[i];
            }

            return result;
        }
        public static bool HasSpecialCharacters(string input)
        {
            foreach (char ch in input)
            {
                if (!Char.IsLetterOrDigit(ch) && !Char.IsWhiteSpace(ch))
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputArray[i] = Console.ReadLine();
            }
            string designation = Console.ReadLine();
            string[] result = UserProgramCodee.getEmployee(inputArray, designation);
            if (result.Length > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }

}
