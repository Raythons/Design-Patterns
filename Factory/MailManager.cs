using System.Text.RegularExpressions;

namespace FactoryMethod.Factory
{
    public abstract class MailManager
    {
        public MailManager() { }

        public  void SendMails(IEnumerable<Person> people)
        {
            foreach (Person person in people)
                SendSingleMail(person);
        }

        private  void SendSingleMail(Person person)
        {
            //var mailServiceType = DetectMailingTypeByIdentifier(person.Idenifier);
            var mailService = CreateMailService(person.Idenifier, "The Content Of The Message That site want to send ");
            mailService.SendMail();

        }
        public abstract IMailService CreateMailService(string identifier, string content);

        public  EnMailType DetectMailingTypeByIdentifier(string identifier)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Use Regex.IsMatch to check if the email matches the pattern
            if (Regex.IsMatch(identifier, emailPattern))
                return EnMailType.Email;
            return EnMailType.SMS;
        }

    }
}
