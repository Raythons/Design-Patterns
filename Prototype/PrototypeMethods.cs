namespace FactoryMethod.Prototype
{
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
