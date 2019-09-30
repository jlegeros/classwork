using System;

namespace Factorialize
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Factorialize.number(5);
            Factorialize.number(10);
            Factorialize.number(20);
            Factorialize.number(0);
        }
    }

    public static class Factorialize
    {
        public static void number(int num)
        {
            long product = 1;
            for (int i = 2; i <= num; i++)
            {
                product = product * i;
            }
            Console.WriteLine(product);
        }
    }
}
