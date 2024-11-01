using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
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
