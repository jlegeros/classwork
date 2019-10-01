using System;

namespace ReturnLargestNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] numberArray1 = new int[,] { { 4, 5, 1, 3 }, { 13, 27, 18, 26 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
            int[,] numberArray2 = new int[,] { { 13, 27, 18, 26 }, { 4, 5, 1, 3 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
            int[,] numberArray3 = new int[,] { { 4, 9, 1, 3 }, { 13, 35, 18, 26 }, { 32, 35, 97, 39 }, { 1000000, 1001, 857, 1 } };
            int[,] numberArray4 = new int[,] { { 17, 23, 25, 12 }, { 25, 7, 34, 48 }, { 4, -10, 18, 21 }, { -72, -3, -17, -10 } };
            Number.LargestOfFour(numberArray1);
            Number.LargestOfFour(numberArray2);
            Number.LargestOfFour(numberArray3);
            Number.LargestOfFour(numberArray4);
        }
    }

    public static class Number
    {
        public static void LargestOfFour(int[,] numbers)
        {
            int arrayElements = numbers.GetLength(0);
            int[] largestArray = new int[arrayElements];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int largest = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (j == 0) largest = numbers[i, j];
                    else
                    {
                        if (largest < numbers[i,j])
                        {
                            largest = numbers[i, j];
                        }
                    }
                }
                largestArray[i] = largest;
            }
            string display = "";
            for (int k = 0; k < largestArray.Length; k++)
            {
                display += largestArray[k] + " ";
            }
            Console.WriteLine(display);
        }
    }
}
