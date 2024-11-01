namespace FactoryMethod.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        public static void Run()
        {
            Senior senior = new();
            Manager manager = new();
            Ceo ceo = new();

            senior.SetNextHandler(manager);
            manager.SetNextHandler(ceo);

            Request request1 = new("Purchase New Equipment", "Requesting approval to purchase new office equipment for the team", ApprovalAuthority.MANAGER);
            Request request2 = new("Employee Training Budget", "Proposal for allocating budget for employee training programs", ApprovalAuthority.CEO);
            Request request3 = new("Project Extension Request", "Seeking approval to extend the deadline for the ongoing project", ApprovalAuthority.SENIOR);
            Request request4 = new("Marketing Campaign Proposal", "Presenting a new marketing campaign strategy for the upcoming product launch", ApprovalAuthority.MANAGER);
            Request request5 = new("Remote Work Policy Update", "Suggestion to update the company's remote work policy for better flexibility", ApprovalAuthority.CEO);

            senior.HandleRequest(request1);
            senior.HandleRequest(request2);
            senior.HandleRequest(request3);
            senior.HandleRequest(request4);
            senior.HandleRequest(request5);
        }
    }
}
