using System;
namespace MVA_Class_Demo
{
    abstract class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string Address { get => address; set => address = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string EmpNumber { get => empNumber; set => empNumber = value; }

        public Employee()
        {
        }

        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }

        public virtual void Logout()
        {
            Console.WriteLine("Employee Logout");
        }

        public abstract void Hire();
    }
}
