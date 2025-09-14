namespace DepartmentManagement
{
    public class Person
    {
        public string Forename { get; private set; }
        public string Surname { get; private set; }
        public string Title { get; private set; }

        public Person(string forename, string surname, string title)
        {
            Forename = forename;
            Surname = surname;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} {Forename} {Surname}";
        }
    }
}
