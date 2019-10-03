using System;

namespace Mod1Lab2
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

    // Declaring the Car() Class
    // This class has 3 propeties: Color, Year, and Mileage
    public class Car
    {
        private static int instances = 0;
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public Car()
        {
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
