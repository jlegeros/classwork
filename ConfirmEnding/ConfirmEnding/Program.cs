using System;

namespace ConfirmEnding
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StringStuff.ConfirmEnding("Bastian", "n");
            StringStuff.ConfirmEnding("Connor", "n");
        }
    }

    public static class StringStuff
    {
        public static void ConfirmEnding(String text, String target)
        {
            Console.WriteLine(text.EndsWith(target));
        }
    }
}
