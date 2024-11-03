using System.Text.Json;

namespace FactoryMethod.Prototype
{
    public abstract class CloneablePrototype<T> : IPrototype<T> where T : class
    {
        public T Clone()
        {
            return (T)MemberwiseClone();
        }
        public T DeepClone()
        {
            var serialized = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<T>(serialized)!;
        }
    }
}
