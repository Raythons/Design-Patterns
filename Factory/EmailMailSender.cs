namespace FactoryMethod.Factory
{
    public class EmailMailSender : IMailService
    {
        public EmailMailSender(string identifier, string content)
        {
            Identifier = identifier;
            Content = content;
        }

        public string Identifier { get; }
        public string Content { get; }

        public void SendMail()
        {
            //  Setting the
            Console.WriteLine($"Sending Mail via {{{"EMAIL"}}} To  {Identifier} Content is : {Content}");
        }
    }
}
