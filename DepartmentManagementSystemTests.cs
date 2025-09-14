using System;
using System.Collections.Generic;
using DepartmentManagement;
using Xunit;

namespace DepartmentManagement.Tests
{
    public class DepartmentManagementSystemTests
    {
        // Method to setup the test data
        private DepartmentManagementSystem CreateDepartmentSystemWithTestData()
        {
            var departmentSystem = new DepartmentManagementSystem();

            // Create some people
            var person1 = new Person("John", "Smith", "Mr");
            var person2 = new Person("Steve", "Jones", "Mr");
            var person3 = new Person("Lisa", "Bradshaw", "Mrs");
            var person4 = new Person("Joanne", "Thompson", "Miss");
            var person5 = new Person("David", "Johnson", "Mr");

            // Create departments and add members
            var purchasingDepartment = new Department("Purchasing", "Top floor");
            purchasingDepartment.AddMember(person1);
            purchasingDepartment.AddMember(person2);
            purchasingDepartment.AddMember(person3);

            var salesDepartment = new Department("Sales", "Bottom floor");
            salesDepartment.AddMember(person3);
            salesDepartment.AddMember(person4);
            salesDepartment.AddMember(person5);

            departmentSystem.AddDepartment(purchasingDepartment);
            departmentSystem.AddDepartment(salesDepartment);

            return departmentSystem;
        }

        // Test to verify GetDepartmentsByPerson works correctly
        [Fact]
        public void GetDepartmentsByPerson_ShouldReturnCorrectDepartments()
        {
            // Arrange
            var departmentSystem = CreateDepartmentSystemWithTestData();

            // Act
            var departments = departmentSystem.GetDepartmentsByPerson("Bradshaw", "Lisa");

            // Assert
            Assert.Contains("Purchasing", departments);
            Assert.Contains("Sales", departments);
        }

        // Test case for non-existing person
        [Fact]
        public void GetDepartmentsByPerson_ShouldReturnEmptyListIfPersonNotFound()
        {
            // Arrange
            var departmentSystem = CreateDepartmentSystemWithTestData();

            // Act
            var departments = departmentSystem.GetDepartmentsByPerson("NonExisting", "Person");

            // Assert
            Assert.Empty(departments);
        }
    }
}
