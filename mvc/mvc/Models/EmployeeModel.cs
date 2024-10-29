using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Models
{
    [Table("tblEmployee")]
    public class EmployeeModel
    {
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone {  get; set; }
        public string Job {  get; set; }
        public double Salary {  get; set; }



    }
}
