using UnitTestingDemo.Models;

namespace nunitDemo
{
    public class Tests
    {
        Employee emp = new Employee();
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase("07/10/2022")]
        public void CorrectDateTime(string joiningDate)
        {

            emp.JoiningDate = DateTime.Parse(joiningDate);

            Assert.IsTrue(emp.NoBeforeToday);
        }

        [Theory]
        [TestCase("07/10/2021")]
        public void InCorrectDateTime(string joiningDate)
        {

            emp.JoiningDate = DateTime.Parse(joiningDate);

            Assert.IsFalse(emp.NoBeforeToday);
        }
        [Theory]
        [TestCase("Keyur", "Somaiya")]
        public void CompareEqual(string firstName, string lastName)
        {
            var fullname = "Keyur Somaiya";

            emp.FirstName = firstName;
            emp.LastName = lastName;


            Assert.AreEqual(fullname, emp.FullName);
        }
    }
}