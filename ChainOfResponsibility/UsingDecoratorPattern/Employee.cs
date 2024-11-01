namespace FactoryMethod.ChainOfResponsibility.UsingDecoratorPattern
{
    public class Employee : IHandler
    {
        protected IHandler nextHandler = null;
        public Employee(IHandler _nextHandler)
        {
            nextHandler = _nextHandler;
        }
        public Employee()
        {
        }
        public virtual void HandleRequest(Request request)
        {
            nextHandler?.HandleRequest(request);
        }
    }
}
