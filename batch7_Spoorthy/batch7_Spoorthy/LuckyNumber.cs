using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class LuckyNumber
    {
        static void Main(string[] args)
    {
        int input1, input2;
        input1 = Convert.ToInt16(Console.ReadLine());
        input2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(UserMainCode.luckynumbers(input1, input2));
    }
}
    class UserMainCode
    {
        public static int luckynumbers(int m, int n)
        {
            int output = 0;
            int cnt = 0;
            for (int i = m; i <= n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt != 2)
                {
                    if (sumof(i * i) == (sumof(i) * sumof(i)))
                    {
                        output++;
                    }
                }
            }
            return output;
        }
        public static int sumof(int number)
        {
            int number1 = number;
            int sum = 0;
            int r = 0;
            while (number1 > 0)
            {
                r = number1 % 10;
                sum = sum + r;
                number1 = number1 / 10;
            }
            return sum;
        }
    }


}

