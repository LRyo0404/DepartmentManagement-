using System;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentManagement
{
    public class DepartmentManagementSystem
    {
        private List<Department> departments;

        public DepartmentManagementSystem()
        {
            departments = new List<Department>();
        }

        // Add a department to the system
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        // Function to get surnames by department name
        public IList<string> GetSurnamesByDepartmentName(string departmentName)
        {
            var department = departments.FirstOrDefault(d => d.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase));

            if (department == null)
            {
                throw new ArgumentException($"Department with the name '{departmentName}' does not exist.");
            }

            return department.Members.Select(m => m.Surname).ToList();
        }

        // Function to get department names by person's surname and forename
        public IList<string> GetDepartmentsByPerson(string surname, string forename)
        {
            var departmentsList = new List<string>();

            // Loop through each department and check for the person
            foreach (var department in departments)
            {
                if (department.Members.Any(m => m.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase) &&
                                                 m.Forename.Equals(forename, StringComparison.OrdinalIgnoreCase)))
                {
                    departmentsList.Add(department.Name);
                }
            }

            return departmentsList;
        }
    }
}
