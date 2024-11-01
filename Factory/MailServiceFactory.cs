<<<<<<< HEAD:MailServiceFactory.cs
﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FactoryMethod
//{
//    public  class MailServiceFactory
//    {
//        public  IMailService CreateMailService(EnMailType mailServiceType, string identifier, string content)
//        {
//            switch (mailServiceType)
//            {
//                case EnMailType.SMS:
//                    return new SMSMailSender(identifier, content);
//                case EnMailType.Email:
//                    return new EmailMailSender(identifier, content);
//                // default here for nthoing u can make it nullable or  u can make default value or smth
//                default:
//                    return new SMSMailSender(identifier, content);
//            }
//        }

 
//    }
//}
=======
﻿namespace FactoryMethod.Factory
{
    public class MailServiceFactory : MailManager
    {
        public override IMailService CreateMailService(EnMailType mailServiceType, string identifier, string content)
        {
            switch (mailServiceType)
            {
                case EnMailType.SMS:
                    return new SMSMailSender(identifier, content);
                case EnMailType.Email:
                    return new EmailMailSender(identifier, content);
                // default here for nthoing u can make it nullable or  u can make default value or smth
                default:
                    return new SMSMailSender(identifier, content);
            }
        }
    }
}
>>>>>>> 543d4c98a1cffeac1116343d2e1582db16edf7d7:Factory/MailServiceFactory.cs
