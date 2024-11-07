namespace FactoryMethod.Factory
{
    public abstract class Employee : Person
    {
        public Employee(string name, string idenifier, string password, decimal payPerHours)
            : base(name, idenifier, password)
        {
            PayPerHours = payPerHours;
        }

        public decimal PayPerHours { get; }

        public virtual decimal CalculateMonthlySalary()
        {
            return PayPerHours * DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        }
    }
}
