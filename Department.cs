using System;
using System.Collections.Generic;

namespace DepartmentManagement
{
    public class Department
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        private List<Person> _members;

        // Public property to expose the members list
        public List<Person> Members
        {
            get { return _members; }
        }

        public Department(string name, string location)
        {
            Name = name;
            Location = location;
            _members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            _members.Add(person);
        }

        public void PrintMembers()
        {
            Console.WriteLine($"Members of the {Name} department:");
            foreach (var member in _members)
            {
                Console.WriteLine(member);
            }
        }
    }
}
