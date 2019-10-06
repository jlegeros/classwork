using System;
using System.Collections.Generic;

namespace MOSH_58e
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>Problem 1<<<<");

            var friendList = new List<string>();
            while (true)
            {
                Console.Write("Enter a friends name: ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                friendList.Add(input);
            }

            switch (friendList.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{friendList[0]} likes your post");
                    break;
                case 2:
                    Console.WriteLine($"{friendList[0]} and {friendList[1]} like your post");
                    break;
                default:
                    Console.WriteLine($"{friendList[0]}, {friendList[1]} and {friendList.Count - 2} others like your post");
                    break;
            }

            Console.WriteLine("\n\n>>>>Problem 2<<<<");

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            var splitName = name.ToCharArray();
            Array.Reverse(splitName);

            Console.WriteLine(string.Join("", splitName));

            Console.WriteLine("\n\n>>>>Problem 3<<<<");

            var count = 0;
            var numArray = new int[5];
            while (count < 5)
            {
                Console.Write($"Enter the {count + 1} number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                var numberIsUnique = true;
                for (var i = 0; i < count; i++)
                {
                    if (input == numArray[i])
                    {
                        Console.WriteLine("Please enter a unique number...");
                        numberIsUnique = false;
                        break;
                    }
                }
                if (numberIsUnique)
                {
                    numArray[count] = input;
                    count++;
                }
            }
            Array.Sort(numArray);
            foreach (var num in numArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n\n>>>>Problem 4<<<<");

            var listOfNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or type quit to finish): ");
                var input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                listOfNumbers.Add(Convert.ToInt32(input));
            }

            listOfNumbers.Sort();
            var previous = listOfNumbers[0] - 1;
            foreach (var numb in listOfNumbers)
            {
                if (numb != previous)
                {
                    Console.WriteLine(numb);
                    previous = numb;
                }
            }

            Console.WriteLine("\n\n>>>>Problem 5<<<<");
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a comma seperated list of 5 or more numbers");
                var csInput = Console.ReadLine();
                var arr = csInput.Split(',');
                foreach (var numb in arr)
                {
                    numbers.Add(Convert.ToInt32(numb));
                }
                if (numbers.Count >= 5)
                {
                    break;
                }
                Console.WriteLine("Ugh... invalid list");
                numbers.Clear();
            }

            numbers.Sort();
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
            

        }
    }
}
