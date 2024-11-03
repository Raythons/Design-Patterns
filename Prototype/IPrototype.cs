namespace FactoryMethod.Prototype
{
    public interface IPrototype<T> where T : class
    {
        T Clone();
        T DeepClone();
    }
}
