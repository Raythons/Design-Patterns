namespace FactoryMethod.ChainOfResponsibility.UsingDecoratorPattern
{
    public class Senior : Employee
    {
        public override void HandleRequest(Request request)
        {
            if (request.authority == ApprovalAuthority.SENIOR)
            {
                Console.WriteLine("Request approved by Senior");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
