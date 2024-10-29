using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public interface ApplyDiscount
    {
        void ApplyDiscount(int discount_percentage);
    }
    public abstract class Cosmetics
    {
        public string Brand;
        public int Price = 200;
        public Cosmetics()
        {
            Console.WriteLine("the brand name is Lakme");
        }
        public Cosmetics(string brand, int price)
        {
            Brand = brand;
            Price = price;
        }

        string shade = "dusky";
        void brand(string shade)
        {
            Console.WriteLine("shade is dusky");
        }
        public void IsExpensive()
        {
            Console.WriteLine(Price > 100 ? "this is expensive" : "this is affordable");
        }
        public abstract void DisplayDetails();
        public void IsExpensive(int threshold)
        {
            //threshold = 300;
            Console.WriteLine(Price > threshold ? "this is expensive" : "this is affordable");
        }
    }
        
    public class Lipstick : Cosmetics, ApplyDiscount 
    {
        public string Color;
        public Lipstick(string brand, string color, int price)
        {
            this.Brand=brand;
            this. Price = price;
           Color= color;

        }
        public override void DisplayDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"lipstick brand:{Brand},color:{Color},price:{Price}");
        }
        public void ApplyDiscount(int discount_percentage)
        {
            Price -= Price * discount_percentage / 100;
            Console.WriteLine("new price after discount" + Price);
        }
        class OopsCosmetics
        {
            static void Main(string[] args)
            {
                Lipstick obj = new Lipstick("Lakme","red",300);
                //Cosmetics obj2 = new Cosmetics(obj);
                //obj.cosmetics();
                //obj.cosmetics(45);
                //obj.isexpensive();
                //obj.brand("dusky");
                obj.DisplayDetails();
                obj.IsExpensive(300);
                obj.ApplyDiscount(10);
            }
        }
    }
}
