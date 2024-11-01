using FactoryMethod.Factory;

//var mailSender = new EmailMailSender("Rasheed", "A  content");
//mailSender.SendMail();

MailManager mailManager = new EmaiMailManager();
MailManager sms = new EmaiMailManager();
var people = FakeDatabase.FillDataBase();
MailManager.SendMails(people);
