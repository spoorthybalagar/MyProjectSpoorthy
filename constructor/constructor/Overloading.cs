using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Overloading
    {
        public void show()
        {
            Console.WriteLine("this is defult parameter");
        }
        public void show(int x)
        {
            Console.WriteLine(x);
        }
        public void show(string s)
        {
            Console.WriteLine("string value is:-" + s);
        }
        public void show(int x, string s)
        {
            Console.WriteLine(x + s);
        }
        public void show(string s, int x)
        {
            Console.WriteLine(s + x);
        }
        static void Main()
        {
            Overloading obj = new Overloading();
            obj.show(); obj.show(10); obj.show("hello");
            obj.show(10, "Hello");
            obj.show("Hello", 10);
            Console.ReadLine();
        }
        }
}
