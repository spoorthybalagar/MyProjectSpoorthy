using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    using System;
    using System.Globalization;

    class UserProgramCode4
    {
        public static int checkEmpAgeEligible(string input1, int input2)
        {
            DateTime dob;
            if (!DateTime.TryParseExact(input1, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
            {
                return -1;
            }
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear) age--;
            if (input2 != 12 && input2 != 24 && input2 != 36 && input2 != 48)
            {
                return -2;
            }
            int loanAmount = 0;
            double rateOfInterest = 0;

            if (age <= 22)
            {
                loanAmount = 200000;
                rateOfInterest = 0.03;
            }
            else if (age > 22 && age <= 45)
            {
                loanAmount = 300000;
                rateOfInterest = 0.05;
            }
            else if (age > 45 && age <= 100)
            {
                loanAmount = 500000;
                rateOfInterest = 0.07;
            }
            else
            {
                return -1; 
            }

            double monthlyInterestRate = rateOfInterest / 12;
            double emi = (loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, input2)) /
                         (Math.Pow(1 + monthlyInterestRate, input2) - 1);
            return (int)Math.Round(emi);
        }
    }

    class EmiProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Date of Birth (dd-MM-yyyy): ");
            string dob = Console.ReadLine();

            Console.Write("Enter EMI months (12, 24, 36, 48): ");
            int emiMonths = int.Parse(Console.ReadLine());

            int result = UserProgramCode4.checkEmpAgeEligible(dob, emiMonths);

            Console.WriteLine(result);
        }
    }

}
