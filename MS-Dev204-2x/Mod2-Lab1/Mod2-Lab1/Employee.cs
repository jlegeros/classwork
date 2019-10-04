using System;
namespace Mod2Lab1
{
    public abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // why initialize to 1???
        private static int employeeCount = 1;

        public string Name { get => employeeName; set => employeeName = value; }

        public double BaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }

        public int ID { get => employeeId; set => employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getEmployeeID()
        {
            return this.ID;
        }

        public string toString()
        {
            return $"{this.ID} {this.Name}";
        }

        public abstract string employeeStatus();
    }
}
