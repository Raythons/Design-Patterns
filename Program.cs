// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");

//var mailSender = new EmailMailSender("Rasheed", "A  content");
//mailSender.SendMail();

MailManager mailManager = new EmaiMailManager();
MailManager SMS = new EmaiMailManager();

List<Person> people = new List<Person>();

for (int i = 0; i < 30; i++)
{
    string name = $"Person {i + 1}";
    string identifier = i % 2 == 0 ? $"person{i}@example.com" : $"555-123-{i:0000}";
    string password = "password123";
    decimal payPerHour = 25.0M ;

    people.Add( new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Teacher(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));
    people.Add(new Coach(name, identifier, password, payPerHour));

}

mailManager.SendMails(people);
