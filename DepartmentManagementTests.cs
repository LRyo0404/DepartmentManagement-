using System;
using System.Linq;
using Xunit;

namespace DepartmentManagement.Tests
{
    public class DepartmentTests
    {
        [Fact]
        public void Test_Department_Members()
        {
            // Arrange: Get the test data
            var departments = TestData.GetDepartments();

            // Test the "Purchasing" department
            var purchasingDepartment = departments.First(d => d.Name == "Purchasing");
            Assert.Equal(3, purchasingDepartment.Members.Count);  // Should have 3 members
            Assert.Contains(purchasingDepartment.Members, m => m.Surname == "Smith");
            Assert.Contains(purchasingDepartment.Members, m => m.Surname == "Jones");
            Assert.Contains(purchasingDepartment.Members, m => m.Surname == "Bradshaw");

            // Test the "Sales" department
            var salesDepartment = departments.First(d => d.Name == "Sales");
            Assert.Equal(3, salesDepartment.Members.Count);  // Should have 3 members
            Assert.Contains(salesDepartment.Members, m => m.Surname == "Bradshaw");
            Assert.Contains(salesDepartment.Members, m => m.Surname == "Thompson");
            Assert.Contains(salesDepartment.Members, m => m.Surname == "Johnson");
        }

        [Fact]
        public void Test_Person_Creation()
        {
            // Arrange
            var people = TestData.GetPeople();

            // Assert person details
            Assert.Equal("John", people[0].Forename);
            Assert.Equal("Smith", people[0].Surname);
            Assert.Equal("Mr", people[0].Title);

            Assert.Equal("Steve", people[1].Forename);
            Assert.Equal("Jones", people[1].Surname);
            Assert.Equal("Mr", people[1].Title);

            Assert.Equal("Lisa", people[2].Forename);
            Assert.Equal("Bradshaw", people[2].Surname);
            Assert.Equal("Mrs", people[2].Title);
        }
    }
}
