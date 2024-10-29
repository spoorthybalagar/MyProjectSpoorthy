using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class Delegates
    {
        public delegate void Math(int x, int y);
        public void add(int x, int y) {
            Console.WriteLine("add: " + (x + y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub: " + (x - y));
        }
        public void mul(int x, int y)
        {
            Console.WriteLine("mul: " + (x * y));
        }
        public void div(int x, int y)
        {
            Console.WriteLine("div: " + (x / y));
        }
        static void Main()
        {
            Delegates obj = new Delegates();
            Math m = new Math(obj.add);
            m += obj.sub;
            m +=obj.mul;
            m+= obj.div;
            m(100, 50);
            Console.WriteLine();
            m(450, 70);
            Console.WriteLine();
            m-= obj.div;
            m(625, 25);


        }
    }
}
