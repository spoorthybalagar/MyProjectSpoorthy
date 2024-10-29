using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class StringAPI
    {
        static void Main(string[] args)
        {
            //System.String authorName = "Mahesh Chand";
            //System.String age = "33";
            //System.String numberString = "33.23";
            //Console.WriteLine("Name: {0}", authorName);
            //Console.WriteLine("Age: {0}", age);
            //Console.WriteLine("Number: {0}", numberString);
            //Console.ReadKey();
            //  string authorInfo = "Mahesh Chand is 33 years old.";
            //  int startPosition = authorInfo.IndexOf("is ") + 1;
            //  string age = authorInfo.Substring(startPosition + 2, 2);
            //Console.WriteLine("Age: " + age);
              string nullStr = null;
             string empStr = string.Empty;
              string name = "Mahesh Chand";
            
  if ((name != nullStr) || (name != empStr))
                  {
                Console.WriteLine(name + " is neither null nor empty");
                  }



        }

    }
}
