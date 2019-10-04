using System;
namespace Mod2Lab1
{
    public class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000)
        {
        }

        public override string employeeStatus()
        {
            return $"{this.toString()} has {this.successfulCheckIns} successful check ins";
        }
    }
}
