using FactoryMethod.Factory;

internal static class FakeDatabase
{
    public static List<Person> FillDataBase()
    {
        List<Person> people = new();
        for (int i = 0; i < 30; i++)
        {
            string name = $"Person {i + 1}";
            string identifier = i % 2 == 0 ? $"person{i}@example.com" : $"555-123-{i:0000}";
            string password = "password123";
            decimal payPerHour = 25.0M;

            people.Add(new Teacher(name, identifier, password, payPerHour));
            people.Add(new Coach(name, identifier, password, payPerHour));
        }
        return people;
    }
}
