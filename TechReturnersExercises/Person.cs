namespace TechReturners
{

    public class Person
    {

        public Person(string firstname, string lastname, string city, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            City = city;
            Age = age;
        }

        public string Firstname
        { get; set; }

        public string Lastname
        { get; set; }

        public string City
        { get; set; }

        public int Age
        { get; set; }
    }
}

