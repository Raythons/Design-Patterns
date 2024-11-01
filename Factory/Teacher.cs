namespace FactoryMethod.Factory
{
    public class Teacher : Employee
    {
        public Teacher(string name, string idenifier, string password, decimal payPerHours)
            : base(name, idenifier, password, payPerHours)
        {
        }

        public override decimal CalculateMonthlySalary()
        {
            return base.CalculateMonthlySalary() * 9000;
        }
    }
}
