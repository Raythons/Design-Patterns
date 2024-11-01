namespace FactoryMethod.ChainOfResponsibility.UsingDecoratorPattern
{
    public class Request
    {
        public string title;
        public string description;
        public ApprovalAuthority authority;

        public Request(string title, string description, ApprovalAuthority authority)
        {
            this.title = title;
            this.description = description;
            this.authority = authority;
        }
    }
}
