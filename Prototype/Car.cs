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

    public static class PrototypeMethods
    {
        public static void Test()
        {
            var car = new Car();
            var part = new Part { IsBroken = false, Name = "Engine", Price = 2000 };
            car.Parts.Add(part);
            var car2 = car.DeepCopy();
            car.Parts[0].Name = "Wheel";
            foreach (var p in car.Parts)
            {
                Console.WriteLine("car1: " + p.Name);
            }
            foreach (var p in car2.Parts)
            {
                Console.WriteLine("car2: " + p.Name);
            }
        }
    }
}
