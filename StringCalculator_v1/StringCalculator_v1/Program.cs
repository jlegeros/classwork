/* Given a string as an argument, parse the string and perform the equation
 * string example: "5 + 7" return 12
 * example: "8 - 2" return 6
 * version 1 accepts two ints and one operator
 */

using System;

namespace StringCalculator_v1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean loop = true;

            while (loop)
            {
                Console.WriteLine("Enter an equation to solve or type X to exit:");
                string input = Console.ReadLine();

                if (input == "X")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine(strCalc(input));
                }

            }
            
        }

        /* strCalc accepts a string as a parameter in the format of
         * int (space) operator (space) int
         * and returns the value of the equation
         */
        public static int strCalc(string input)
        {
            string[] equation = input.Split(' ');
            int value = 0;

            switch (equation[1])
            {
                case "+":
                    value = Int32.Parse(equation[0]) + Int32.Parse(equation[2]);
                    return value;
                    break;
                case "-":
                    value = Int32.Parse(equation[0]) - Int32.Parse(equation[2]);
                    return value;
                    break;
                case "/":
                    value = Int32.Parse(equation[0]) / Int32.Parse(equation[2]);
                    return value;
                    break;
                case "*":
                    value = Int32.Parse(equation[0]) * Int32.Parse(equation[2]);
                    return value;
                    break;
                case "%":
                    value = Int32.Parse(equation[0]) % Int32.Parse(equation[2]);
                    return value;
                    break;
                default:
                    Console.WriteLine("Invalid operator specified, please use '+ - / * or %'");
                    break;
            }
            return 0;
        }
    }
}
