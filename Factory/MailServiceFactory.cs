namespace FactoryMethod.Factory
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
