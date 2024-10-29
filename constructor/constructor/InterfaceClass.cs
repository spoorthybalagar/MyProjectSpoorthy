using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
   
    interface Inter1
    {
        void add(int x, int y);
        void sub(int x, int y);
        void test();
    }
    interface Inter2
    {
        void mul(int r, int y);
        void div(int x, int y);
        void test();
    }
     class InterfaceClass : Inter1, Inter2
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        void Inter1.test()
        {
            Console.WriteLine("method of interface1");
        }
        void Inter2.test()
        {
            Console.WriteLine("method of interface2");
        }
        static void Main(string[] args)
        {
            InterfaceClass c = new InterfaceClass();
            c.add(100, 25); c.sub(100, 25);
            c.mul(100, 25); c.div(100, 25);
            Inter1 i1 = c; Inter2 i2 = c;
            i1.test(); i2.test();
            Console.ReadLine();
        }
    }


}
