namespace FactoryMethod.ChainOfResponsibility
{
    public class Manager : Employee
    {
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
