namespace SimpleLists02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Marcia", Country = CountryEnum.ES, Age = 29 });
            people.Add(new Person() { Name = "Sabine", Country = CountryEnum.IT, Age = 25 });
            people.Add(new Person() { Name = "Anne", Country = CountryEnum.CA, Age = 31 });

            List<Person> results = people.OrderBy(p => p.Name).ToList();
            foreach (Person person in results)
            {
                Console.WriteLine($"{person.Name} {person.Age} years old from {person.Country}.");
            }

            List<string> names = people.Where(p => p.Age > 30).OrderBy(p => p.Name).Select(p => p.Name).ToList();
            foreach (string name in names)
            {
                Console.WriteLine($"{name} is over 30 years old.");
            }

            List<string> namess = people.Where(p => p.Age <= 30).OrderBy(p => p.Name).Select(p => p.Name).ToList();
            foreach (string name in namess)
            {
                Console.WriteLine($"{name} is under 30 years old.");
            }
        }
    }
}
