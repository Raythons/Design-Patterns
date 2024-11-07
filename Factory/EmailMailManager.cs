namespace FactoryMethod.Factory
{
    public class EmailMailManager : MailManager
    {
        public override IMailService CreateMailService(string identifier, string content)
        {
            return new EmailMailSender(identifier, content);
        }
    }
}
