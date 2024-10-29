using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Basic
    {
        static void Main(string[] args)
        {
            //basic 
            //1.int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("you are" + age + "years old");
            // 2.for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("*****");
            //}
            // 3.int a=10;
            //float b = 12.5f;
            //string c = "c# programming";
            //int d;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //4. string name=Console.ReadLine();
            //  Console.WriteLine("hello" + name + "!");

            //operator 
            //1.int x = 10;
            //int y = 5;
            //Console.WriteLine(x = y + 3);
            //Console.WriteLine(x = y - 2);
            //Console.WriteLine(x = y * 5);
            //Console.WriteLine(x = x / y);
            //Console.WriteLine(x = x % y);
            //Console.WriteLine(x += y);
            //Console.WriteLine(x = y-2);
            //Console.WriteLine(x *= y*5);
            //Console.WriteLine(x /=x/ y);
            //Console.WriteLine(x %= y);
            //2.int a = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(a++);
            //Console.WriteLine(++a);
            //Console.WriteLine(a--);
            //Console.WriteLine(--a);
            Console.WriteLine("enter the name of the choice");
            string choice=Console.ReadLine();
            Console.WriteLine("enter the number of chocolates");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case "Dairymilk":
                    Console.WriteLine("dairymilk");
                    break;
                case "kitkat":
                    Console.WriteLine("kitkat");
                    break;
                case "sneakers":
                    Console.WriteLine("sneakers");
                    break;
                case "5star":
                    Console.WriteLine("5star");
                    break;
                case "milkybar":
                    Console.WriteLine("milkybar");
                    break;
                }
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("one chocolate");
                    break;
                case 2:
                    Console.WriteLine("two chocolate");
                    break;
                case 3:
                    Console.WriteLine("three chocolate");
                    break;
                case 4:
                    Console.WriteLine("four chocolate");
                    break;
                case 5:
                    Console.WriteLine("five chocolate");
                    break;
            }
            int price = 30;
            int total_cost=choice2*price;
            Console.WriteLine("the total cost is" + total_cost + "for" + choice2 + "chocolates");

        }
    }
}
