namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Person> people = new SortedList<string, Person>();

            people.Add("Marcia", new Person() { Name = "Marcia", Country = CountryEnum.ES, Age = 29 });
            people.Add("Sabine", new Person() { Name = "Sabine", Country = CountryEnum.IT, Age = 25 });
            people.Add("Anne", new Person() { Name = "Anne", Country = CountryEnum.CA, Age = 31 });

            foreach (KeyValuePair<string, Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} {person.Value.Age} years old from {person.Value.Country}.");
            }

        }
    }
}