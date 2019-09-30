using System;

namespace ReverseAString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyString.reverseString("Test");
            MyString.reverseString("hello");
            MyString.reverseString("Howdy");
            MyString.reverseString("Greetings from Earth");
        }
    }

    public static class MyString
    {
        public static void reverseString(string arg)
        {
            var reversedChars = new char[arg.Length];
            var count = 0;
            for (int i = arg.Length - 1; i >= 0; i--)
            {
                reversedChars[count] = arg[i];
                count++;
            }
            Console.WriteLine(reversedChars);
        }
    }
}
