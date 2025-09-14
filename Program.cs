using System;

namespace DepartmentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some people
            var person1 = new Person("John", "Smith", "Mr");
            var person2 = new Person("Steve", "Jones", "Mr");
            var person3 = new Person("Lisa", "Bradshaw", "Mrs");
            var person4 = new Person("Joanne", "Thompson", "Miss");
            var person5 = new Person("David", "Johnson", "Mr");

            // Create departments
            var purchasingDepartment = new Department("Purchasing", "Top floor");
            purchasingDepartment.AddMember(person1);
            purchasingDepartment.AddMember(person2);
            purchasingDepartment.AddMember(person3);

            var salesDepartment = new Department("Sales", "Bottom floor");
            salesDepartment.AddMember(person3);
            salesDepartment.AddMember(person4);
            salesDepartment.AddMember(person5);

            // Create Department Management System
            var departmentSystem = new DepartmentManagementSystem();
            departmentSystem.AddDepartment(purchasingDepartment);
            departmentSystem.AddDepartment(salesDepartment);

            // Call GetDepartmentsByPerson function
            var personDepartments = departmentSystem.GetDepartmentsByPerson("Bradshaw", "Lisa");

            Console.WriteLine("Departments that Lisa Bradshaw is in:");
            foreach (var departmentName in personDepartments)
            {
                Console.WriteLine(departmentName);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
