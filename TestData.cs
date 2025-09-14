using System;
using System.Collections.Generic;

namespace DepartmentManagement.Tests
{
    public static class TestData
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person("John", "Smith", "Mr"),
                new Person("Steve", "Jones", "Mr"),
                new Person("Lisa", "Bradshaw", "Mrs"),
                new Person("Joanne", "Thompson", "Miss"),
                new Person("David", "Johnson", "Mr")
            };
        }

        public static List<Department> GetDepartments()
        {
            var people = GetPeople();
            var purchasingDepartment = new Department("Purchasing", "Top floor");
            purchasingDepartment.AddMember(people[0]); // John Smith
            purchasingDepartment.AddMember(people[1]); // Steve Jones
            purchasingDepartment.AddMember(people[2]); // Lisa Bradshaw

            var salesDepartment = new Department("Sales", "Bottom floor");
            salesDepartment.AddMember(people[2]); // Lisa Bradshaw
            salesDepartment.AddMember(people[3]); // Joanne Thompson
            salesDepartment.AddMember(people[4]); // David Johnson

            return new List<Department> { purchasingDepartment, salesDepartment };
        }
    }
}
