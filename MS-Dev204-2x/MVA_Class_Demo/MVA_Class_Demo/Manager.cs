using System;
namespace MVA_Class_Demo
{
    class Manager : Employee
    {
        private string department;

        public string Department { get => department; set => department = value; }

        public Manager()
        {
        }

        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire an employee");
        }
    }
}
