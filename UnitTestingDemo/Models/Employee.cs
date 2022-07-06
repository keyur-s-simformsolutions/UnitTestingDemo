using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnitTestingDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
        [NotMapped]
        public decimal JoinedbeforOneyear { get { return Salary + 50000; } }
        [NotMapped]
        public Boolean NoBeforeToday { get { return DateTime.Compare(JoiningDate,DateTime.Now) >= 0 ; } }
    }
   
}
