using System;

namespace LongestStringInWork
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Word.sizeofLongestWord("The quick brown fox jumped over the lazy dog");
            Word.sizeofLongestWord("May the force be with you");
            Word.sizeofLongestWord("Google do a barrel roll");
            Word.sizeofLongestWord("What is the average airspeed velocity of an unladen swallow");
            Word.sizeofLongestWord("What if we try a super-long word such as otorhinolaryngology");
        }
    }

    public static class Word
    {
        public static void sizeofLongestWord(string arg)
        {
            string[] words = arg.Split(' ');
            int longest = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longest)
                {
                    longest = words[i].Length;
                }
            }
            Console.WriteLine(longest);
        }
    }
}
