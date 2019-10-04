using System;

namespace MOSH_42e
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>Problem 1<<<<");
            Console.WriteLine("Enter an integer between 1 and 10:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid!");
            } else
            {
                Console.WriteLine("Invalid!");
            }

            Console.WriteLine("\n\n>>>>Problem 2<<<<");
            Console.WriteLine("Enter the first number:");
            int minmaxNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int minmaxNum2 = Convert.ToInt32(Console.ReadLine());

            if (minmaxNum1 > minmaxNum2)
            {
                Console.WriteLine($"{minmaxNum1} is the bigger number!");
            } else if (minmaxNum2 > minmaxNum1)
            {
                Console.WriteLine($"{minmaxNum2} is the bigger number!");
            } else
            {
                Console.WriteLine("They're the same, and you're a jerk...");
            }

            Console.WriteLine("\n\n>>>>Problem 3<<<<");
            Console.WriteLine("Enter the height of the image:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the image:");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("The image is portrait");
            } else if (width > height)
            {
                Console.WriteLine("The image is landscape");
            } else
            {
                Console.WriteLine("The image is square, and you're a jerk!");
            }

            Console.WriteLine("\n\n>>>>Problem 4<<<<");
            Console.WriteLine("Speed camera in effect, what is your speed?");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And, what is the speed limit?");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            if (speed <= speedLimit)
            {
                Console.WriteLine("OK!");
            } else
            {
                var speedOverLimit = speed - speedLimit;
                if (speedOverLimit > 12)
                {
                    Console.WriteLine("Your license is suspended, jerk.");
                } else
                {
                    Console.WriteLine($"You've earned {speedOverLimit/5} demerit points!");
                }
            }
        }
    }
}
