namespace FactoryMethod.Factory
{
    public class SMSMailSender : IMailService
    {
        public SMSMailSender(string identifier, string content)
        {
            Identifier = identifier;
            Content = content;
        }
        public string Identifier { get; }
        public string Content { get; }

        public void SendMail()
        {
            Console.WriteLine($"Sending Mail To  ${Identifier} Content is : ${Content}");
        }
    }
}
