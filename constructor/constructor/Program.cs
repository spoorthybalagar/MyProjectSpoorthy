namespace constructor
{
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    int EmpId;

        //    double Basic, DA, HRA, Gross;

        //    string EName;
        //}
        int EmpId;

        double Basic, DA, HRA, Gross;

        string EName;

        public void GetSalData()

        {

            Console.WriteLine("Enter Employee Details:-");

            this.EmpId = Convert.ToInt32(Console.ReadLine());

            this.EName = Console.ReadLine();

            this.Basic = int.Parse(Console.ReadLine());

        }

        public void Calculate()
        {

            this.DA = 0.4 * this.Basic;

            this.Gross = this.Basic * this.DA + this.HRA;

            this.HRA = 0.3 * this.Basic;

        }
        public void DisplaySalData()
        {

            Console.WriteLine("Employee empld is:-" + this.EmpId);
            Console.WriteLine("Employee Name is:-" + this.EName);
            Console.WriteLine("Employee Basic is" + this.Basic);
            Console.WriteLine("Employee, DA is:" + this.DA);
            Console.WriteLine("Employee HRA is" + this.HRA);
            Console.WriteLine("Employee Gross is" + this.Gross);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetSalData();
            program.Calculate();
            program.DisplaySalData();
            
        }
    }
    }

