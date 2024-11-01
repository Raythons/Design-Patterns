namespace FactoryMethod.ChainOfResponsibility.UsingDecoratorPattern
{
    public class Manager : Employee
    {
        public Manager(IHandler _nextHandler) : base(_nextHandler)
        {
        }
        public override void HandleRequest(Request request)
        {
            if (request.authority == ApprovalAuthority.MANAGER)
            {
                Console.WriteLine("Request approved by Manager");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
