namespace FactoryMethod.ChainOfResponsibility
{
    public class Employee : IHandler
    {
        protected IHandler nextHandler = null;

        public void SetNextHandler(IHandler handler)
        {
            nextHandler = handler;
        }

        public virtual void HandleRequest(Request request)
        {
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
