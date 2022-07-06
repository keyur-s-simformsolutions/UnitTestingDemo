using UnitTestingDemo.Models;
using Xunit;

namespace xunitDemo
{
    public class XUnitDemo
    {
        Employee emp = new Employee();

        [Theory]
        [InlineData("Keyur", "Somaiya")]
        public void CompareEqual(string firstName, string lastName)
        {
            var fullname= "Keyur Somaiya";

            emp.FirstName = firstName;
            emp.LastName = lastName;

            
            Assert.Equal(fullname, emp.FullName);
        }

        [Theory]
        [InlineData("Keyur", "Somaiya")]
        public void NotEqualCompare(string firstName, string lastName)
        {
            var fullname = "Keyur M Somaiya";

            emp.FirstName = firstName;
            emp.LastName = lastName;

            Assert.NotEqual(fullname, emp.FullName);
        }

        [Theory]
        [InlineData(50000)]
        public void CompareEqualSalary(int salary)
        {
            int sal = 100000;

            emp.Salary = salary;
         

            Assert.Equal(sal, emp.JoinedbeforOneyear);
        }
        [Theory]
        [InlineData(50000)]
        public void NotCompareEqualSalary(int salary)
        {
            int sal = 100001;

            emp.Salary = salary;


            Assert.NotEqual(sal, emp.JoinedbeforOneyear);
        }
        [Theory]
        [InlineData("07/10/2022")]
        public void CorrectDateTime(string joiningDate)
        {
           
            emp.JoiningDate = DateTime.Parse(joiningDate);

            Assert.Equal(true, emp.NoBeforeToday);
        }

        [Theory]
        [InlineData("07/10/2021")]
        public void InCorrectDateTime(string joiningDate)
        {

            emp.JoiningDate = DateTime.Parse(joiningDate);

            Assert.NotEqual(true, emp.NoBeforeToday);
        }
    }
}