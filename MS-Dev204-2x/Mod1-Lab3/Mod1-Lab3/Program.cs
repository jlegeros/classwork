using System;

namespace Mod1Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2000);

            Console.WriteLine($"There are {Car.CountCars()} cars on inventory right now.");

        }
    }
}
