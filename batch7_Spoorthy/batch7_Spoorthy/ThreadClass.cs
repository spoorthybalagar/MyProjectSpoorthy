﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace batch7_Spoorthy
{
    internal class ThreadClass
    {
        Thread t1, t2;
        public ThreadClass()
        {
            t1 = new Thread(Test1);
            t2 = new Thread(Test2);
            t1.Start();t2.Start();
        }
        public void Test1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("test1: " + i);
                if (i == 10)
                    Thread.Sleep(10000);
            }
            Console.WriteLine("test1 existing");
        }
        public void Test2() {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("test2" + i);
            }
            Console.WriteLine("test2 existing");
        }
        static void Main(string[]args)
        {
            ThreadClass obj=new ThreadClass();
            obj.t1.Join();
            obj.t1.Join();
            Console.WriteLine("main thread existing");
        }
    }
}
