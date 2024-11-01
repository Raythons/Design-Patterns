<<<<<<< HEAD:MailManager.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class MailManager
    {
        public MailManager() { }

        public void SendMails(IEnumerable<Person> people) {
                
            foreach (Person person in people)
                SendSingleMail(person);
        }

        private void SendSingleMail(Person person)
        {
            var mailServiceType = DetectMailingTypeByIdentifier(person.Idenifier);
            var mailService = CreateMailService(person.Idenifier, "The Content Of The Message That site want to send ");
            mailService.SendMail();
        }

        public abstract IMailService CreateMailService(string identifier, string content);
        
        
        //public abstract IMailService CreateMailService(EnMailType mailServiceType, string identifier, string content);  

        public EnMailType DetectMailingTypeByIdentifier(string identifier)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Use Regex.IsMatch to check if the email matches the pattern
            if (Regex.IsMatch(identifier, emailPattern))
                return EnMailType.Email;
            return EnMailType.SMS;
        }

    }
}
=======
﻿using System.Text.RegularExpressions;

namespace FactoryMethod.Factory
{
    public abstract class MailManager
    {
        public static void SendMails(IEnumerable<Person> people)
        {
            foreach (Person person in people)
                SendSingleMail(person);
        }

        private static void SendSingleMail(Person person)
        {
            var mailServiceType = DetectMailingTypeByIdentifier(person.Idenifier);
            var mailService = CreateMailService(mailServiceType, person.Idenifier, "The Content Of The Message That site want to send ");
            mailService.SendMail();
        }

        public abstract IMailService CreateMailService(string identifier, string content);


        //public abstract IMailService CreateMailService(EnMailType mailServiceType, string identifier, string content);  

        public static EnMailType DetectMailingTypeByIdentifier(string identifier)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Use Regex.IsMatch to check if the email matches the pattern
            if (Regex.IsMatch(identifier, emailPattern))
                return EnMailType.Email;
            return EnMailType.SMS;
        }

    }
}
>>>>>>> 543d4c98a1cffeac1116343d2e1582db16edf7d7:Factory/MailManager.cs
