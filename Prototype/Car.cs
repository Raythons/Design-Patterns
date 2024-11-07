namespace FactoryMethod.Prototype
{
    public class Car : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Modal { get; set; } = string.Empty;
        public List<string> Attributes { get; set; } = new List<string>();
        public List<Part> Parts { get; set; } = new List<Part>();

        public object Clone()
        {
            var car = (Car)MemberwiseClone();
            return car;
        }
        public Car DeepCopy()
        {
            var car = (Car)Clone();
            car.Attributes = new(Attributes);
            car.Parts = new(Parts.Count);
            foreach (var part in Parts)
            {
                car.Parts.Add((Part)part.Clone());
            }
            return car;
        }
    }
}
