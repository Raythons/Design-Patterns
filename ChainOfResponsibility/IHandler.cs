namespace FactoryMethod.ChainOfResponsibility
{
    public interface IHandler
    {
        void HandleRequest(Request request);
        void SetNextHandler(IHandler handler);
    }
}
