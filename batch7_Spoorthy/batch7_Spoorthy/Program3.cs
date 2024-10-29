using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;
    using System.Collections.Generic;

    public class UserProgramCodes
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            
            if (ContainsSpecialCharacters(input1) || ContainsSpecialCharacters(new string[] { input2 }))
            {
                Console.WriteLine("Invalid Input");
                return new string[] { };
            }

         
            Dictionary<string, string> employeeDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            
            for (int i = 0; i < input1.Length; i += 2)
            {
                string employee = input1[i];
                string designation = input1[i + 1];
                employeeDict[employee] = designation;
            }

            
            List<string> result = new List<string>();
            foreach (var entry in employeeDict)
            {
                if (entry.Value.Equals(input2, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(entry.Key);
                }
            }

            
            HashSet<string> uniqueDesignations = new HashSet<string>(employeeDict.Values, StringComparer.OrdinalIgnoreCase);
            if (uniqueDesignations.Count == 1 && uniqueDesignations.Contains(input2))
            {
                Console.WriteLine($"All employees belong to same {input2} designation");
                return new string[] { };
            }

       
            if (result.Count == 0)
            {
                Console.WriteLine($"No employee for {input2} designation");
                return new string[] { };
            }

            
            return result.ToArray();
        }

  
        private static bool ContainsSpecialCharacters(string[] input)
        {
            foreach (var str in input)
            {
                foreach (char c in str)
                {
                    if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public class Program3
    {
        static void Main(string[] args) { 
        Console.WriteLine("Enter the number of elements in the employee-designation array:");
        int n = int.Parse(Console.ReadLine());
        string[] input1 = new string[n];

        Console.WriteLine("Enter the employee and designation alternately:");
        for (int i = 0; i<n; i++)
        {
            input1[i] = Console.ReadLine();
        }
    Console.WriteLine("Enter the designation to search for:");
        string input2 = Console.ReadLine();
    string[] result = UserProgramCodes.getEmployee(input1, input2);
        if (result.Length > 0)
        {
            Console.WriteLine("Employees with the given designation:");
            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
        }
}
}

}
