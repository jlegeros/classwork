using System;

namespace MOSH_48e
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>Problem 1<<<<");
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} numbers evenly divisible by 3 in 1 - 100");

            Console.WriteLine("\n\n>>>>Problem 2<<<<");
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number to add, or type ok to exit: ");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine($"The sum of those numbers is {sum}");

            Console.WriteLine("\n\n>>>>Problem 3<<<<");
            Console.Write("Please enter a number you'd like the factorial of: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = number;
            for (var i = 2; i < number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{number}! = {factorial}");

            Console.WriteLine("\n\n>>>>Problem 4<<<<");
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            var guessCounter = 0;
            do
            {
                Console.WriteLine("Guess the number between 1 and 10");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine($"Your guess of {guess} is correct!");
                    break;
                }
                guessCounter++;
                Console.WriteLine($"Your guess of {guess} is WRONG! Tries remaining: {4 - guessCounter}");


            } while (guessCounter < 4);


            Console.WriteLine("\n\n>>>>Problem 5<<<<");
            Console.Write("Enter comma seperated numbers: ");
            var numberString = Console.ReadLine();

            var numberArr = numberString.Split(',');
            int biggest = Convert.ToInt32(numberArr[0]);
            for(var i = 1; i < numberArr.Length; i++)
            {
                var aNum = Convert.ToInt32(numberArr[i]);
                if (aNum > biggest)
                {
                    biggest = aNum;
                }
            }
            Console.WriteLine($"The biggest is {biggest}");
        }
    }
}
