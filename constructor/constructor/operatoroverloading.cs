using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Operatoroverloading
    {
        int a, b, c, d;
        public Operatoroverloading(int a,int b,int c,int d) {
            this.a = a; this.b = b;
            this.c = c; this.d = d;
        }
        public static Operatoroverloading
operator +(Operatoroverloading obj1, Operatoroverloading obj2)
        {
            Operatoroverloading obj = new
           Operatoroverloading(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.
           c, obj1.d + obj2.d);
            return obj;
        }
        public static Operatoroverloading operator -
(Operatoroverloading obj1, Operatoroverloading obj2)
        {
            return new Operatoroverloading(obj1.a - obj2.a,
           obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
        }
        public override string ToString()
        {
            string str =
           string.Format("a:{0},b:{1},c:{2},d{3}", a, b, c, d);
            return str;
        }
    }
    class Matrix
    {
        static void Main()
        {
            Operatoroverloading m1 = new
           Operatoroverloading(5, 6, 7, 8);
            Operatoroverloading m2 = new Operatoroverloading
           (1, 2, 3, 4);
            Operatoroverloading m3 = m1 + m2;
            Operatoroverloading m4 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();
        }
    }

}
    
