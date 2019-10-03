using System;
namespace Mod1Lab3
{
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
