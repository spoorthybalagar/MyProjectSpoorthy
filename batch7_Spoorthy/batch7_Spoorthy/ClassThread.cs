using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class ClassThread
    {
        Thread t1, t2, t3;
        public ClassThread()
        {
            t1 = new Thread(Display);
            t2 = new Thread(Display);
            t3 = new Thread(Display);
            t1.Start();t2.Start();t3.Start();
        }
        public void Display()
        {
            lock (this)
            {
                Console.WriteLine("c# is ");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented");
            }
        }
        static void Main()
        {
            ClassThread obj = new ClassThread();
            obj.t1.Join();obj.t2.Join();obj.t3.Join();
        }
    }
}
