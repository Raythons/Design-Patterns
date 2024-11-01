namespace FactoryMethod.ChainOfResponsibility
{
    public class Ceo : Employee
    {
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
