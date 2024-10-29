using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch7_Spoorthy
{
    internal class Property
    {
        int EmpId, Eage;string Ename, EAddress;
        public int PEmpId
        {
            set
            {
                EmpId = value;
            }
            get
            {
                return EmpId;
            }
        }
        public int PAge
        {
            set
            {
                Eage = value;
            }
            get
            {
                return Eage;
            }
        }
        public string PName
        {
            set
            {
                Ename = value;
            }
            get
            {
                return Ename;
            }
        }
        public string PAddress
        {
            set
            {
                EAddress = value;
            }
            get
            {
                return EAddress;
            }
        }
        static void Main(string[] args)
        {
            Property obj = new Property();
            obj.PEmpId=Convert.ToInt32(Console.ReadLine());
            obj.PAge = Convert.ToInt32(Console.ReadLine());
            obj.PName = Console.ReadLine();
            obj.PAddress = Console.ReadLine();
            //Console.WriteLine(PEmpId);


        }
    }
}
