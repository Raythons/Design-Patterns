namespace FactoryMethod.Factory
{
    public class SMSMailManager : MailManager
    {
        public override IMailService CreateMailService(string identifier, string content)
        {
            return new SMSMailSender(identifier, content);
        }
    }
}
