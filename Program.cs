// See https://aka.ms/new-console-template for more information
using FactoryMethod.Factory;

//var mailSender = new EmailMailSender("Rasheed", "A  content");
//mailSender.SendMail();

MailManager mailManager = new EmaiMailManager();

MailManager SMSManager = new SMSMailManager();

List<Person> people = new List<Person>(FakeDatabase.FillDataBase());



mailManager.SendMails(people);
SMSManager.SendMails(people);

