using System;
using System.Text;

namespace MOSH_67e
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>Problem 1<<<<");

            Console.Write("Enter a few hyphen seperated numbers: ");
            var input = Console.ReadLine();

            var splitInput = input.Split('-');

            var previous = Convert.ToInt32(splitInput[0]);
            var isConsecutive = true;
            for (var i = 1; i < splitInput.Length; i++)
            {
                var current = Convert.ToInt32(splitInput[i]);
                if (current == previous + 1 || current == previous - 1)
                {
                    previous = current;
                    continue;
                }
                isConsecutive = false;
                break;
            }
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            } else
            {
                Console.WriteLine("Not Consecutive");
            }

            Console.WriteLine("\n\n>>>>Problem 2<<<<");

            Console.Write("Enter a few hyphen seperated numbers: ");
            var input2 = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input2))
            {
                var splitInput2 = input2.Split('-');
                var broke = false;
                for (var i = 0; i < splitInput2.Length; i++)
                {
                    for (var j = i + 1; j < splitInput2.Length; j++)
                    {
                        if (splitInput2[i] == splitInput2[j])
                        {
                            broke = true;
                            break;
                        }
                    }
                    if (broke)
                    {
                        break;
                    }
                }
                if (broke)
                {
                    Console.WriteLine("Duplicates exist");
                }
                else
                {
                    Console.WriteLine("No Duplicates exist");
                }
            }

            Console.WriteLine("\n\n>>>>Problem 3<<<<");

            Console.Write("Enter a time value in 24 hour format (00:00 - 23:59): ");
            var input3 = Console.ReadLine();
            var splitInput3 = input3.Split(':');
            if (splitInput3[0].Length == 2 &&
                splitInput3[1].Length == 2 &&
                Convert.ToInt32(splitInput3[0]) >= 0 &&
                Convert.ToInt32(splitInput3[0]) < 24 &&
                Convert.ToInt32(splitInput3[1]) >= 0 &&
                Convert.ToInt32(splitInput3[1]) < 60)
            {
                Console.WriteLine("Okay");
            } else
            {
                Console.WriteLine("Invalid Time...");
            }

            Console.WriteLine("\n\n>>>>Problem 4<<<<");

            Console.Write("Enter a few words seperated by spaces: ");
            var input4 = Console.ReadLine();
            var splitInput4 = input4.ToLower().Split(' ');

            var variableName = new StringBuilder();
            foreach (var word in splitInput4)
            {
                variableName.Append(Convert.ToString(word[0]).ToUpper() + Convert.ToString(word).Substring(1));
            }
            Console.WriteLine(variableName);

            Console.WriteLine("\n\n>>>>Problem 5<<<<");

            Console.Write("Enter a word: ");
            var input5 = Console.ReadLine().ToLower();

            var count = 0;
            for (var i = 0; i < input5.Length; i++)
            {
                if (input5[i] == 'a' ||
                    input5[i] == 'e' ||
                    input5[i] == 'i' ||
                    input5[i] == 'o' ||
                    input5[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} vowels");
        }
    }
}
