namespace FactoryMethod.Factory
{
    public class Coach : Employee
    {
        public Coach(string name, string idenifier, string password, decimal payPerHours)
            : base(name, idenifier, password, payPerHours)
        {
        }

        public override decimal CalculateMonthlySalary()
        {
            return base.CalculateMonthlySalary();
        }
    }
}
