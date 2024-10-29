namespace batch7_Spoorthy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter x value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value");
            y = Convert.ToInt32(Console.ReadLine());
            if (x < y)
            {
                Console.WriteLine("y is greater than x");
            }
            else if (y < x)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }
        }
    }
}
