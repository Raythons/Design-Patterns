using FactoryMethod.Factory;

//var mailSender = new EmailMailSender("Rasheed", "A  content");
//mailSender.SendMail();

MailManager mailManager = new EmaiMailManager();
<<<<<<< HEAD
MailManager SMSManager = new SMSMailManager();

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
SMSManager.SendMails(people);
=======
MailManager sms = new EmaiMailManager();
var people = FakeDatabase.FillDataBase();
MailManager.SendMails(people);
>>>>>>> 543d4c98a1cffeac1116343d2e1582db16edf7d7
