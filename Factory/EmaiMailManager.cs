namespace FactoryMethod.Factory
{
    public class EmaiMailManager : MailManager
    {
        public override IMailService CreateMailService(string identifier, string content)
        {
            return new EmailMailSender(identifier, content);
        }
    }
}
