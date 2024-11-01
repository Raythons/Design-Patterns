namespace FactoryMethod.ChainOfResponsibility.UsingDecoratorPattern
{
    public class Ceo : Employee
    {
        public Ceo(IHandler _nextHandler) : base(_nextHandler)
        {
        }

        public override void HandleRequest(Request request)
        {
            if (request.authority == ApprovalAuthority.CEO)
            {
                Console.WriteLine("Request approved by CEO");
            }
            else
            {
                Console.WriteLine("Request rejected");
            }
        }
    }
}
