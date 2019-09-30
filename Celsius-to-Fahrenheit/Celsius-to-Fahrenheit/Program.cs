using System;

namespace CelsiustoFahrenheit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Celsius.convertToF(0);
            Celsius.convertToF(-30);
            Celsius.convertToF(-10);
            Celsius.convertToF(20);
            Celsius.convertToF(30);
        }
    }

    public static class Celsius
    {
        public static void convertToF(float tempInC)
        {
            Console.WriteLine(tempInC * 9 / 5 + 32);
        }
    }
}
