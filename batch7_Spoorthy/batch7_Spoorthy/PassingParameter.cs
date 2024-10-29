using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class PassingParameter
    {
        void test1()
        {
            Console.WriteLine("this is 1st method");
        }
        void test2(int x)
        {
            Console.WriteLine("this is 2nd method" + x);
        }
        string test3()
        {
            return "this is third method";
        }
        string test4(string name)
        {
            return "hello" + name;
        }
        void math1(int x, int y, ref int a, ref int b)
        {
            a = x - y;
            b = x / y;
        }
        void math2(int x, int y, out int a, out int b) { 
            a=x-y;
            b=x/y;
            }
        static void Main(string[] args)
        {
            PassingParameter p=new PassingParameter();
            p.test1();p.test2(100);
            Console.WriteLine(p.test3());
            Console.WriteLine(p.test4("tej"));
            int m = 0, n = 0; 
            p.math1(100,50,ref m,ref n);
            Console.WriteLine(m+" "+n);
            int q, r;
            p.math2(100, 50, out q, out r);
            Console.WriteLine(q+" "+r);
        }
    }
}
