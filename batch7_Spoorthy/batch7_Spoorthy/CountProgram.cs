using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;

    public class UserProgramCode1
    {
        public static int GetCount(int size, string[] arr, char ch)
        {
            int count = 0;
            ch = char.ToLower(ch);

            foreach (var item in arr)
            {
                if (!IsAllAlphabets(item))
                {
                    return -2;
                }
                if (item.ToLower().StartsWith(ch))
                {
                    count++;
                }
            }
            return count > 0 ? count : -1;
        }

        private static bool IsAllAlphabets(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class CountProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[size];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the character:");
            char ch = Convert.ToChar(Console.ReadLine());
            int result = UserProgramCode1.GetCount(size, arr, ch);
            if (result == -1)
            {
                Console.WriteLine("No elements Found");
            }
            else if (result == -2)
            {
                Console.WriteLine("Only alphabets should be given");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }

}
