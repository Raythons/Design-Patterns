namespace FactoryMethod.Prototype
{
    public class Part : ICloneable
    {
        public double Price { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsBroken { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
