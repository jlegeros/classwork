using System;
namespace Mod1SAL
{
    public class Student
    {
        private string _name;
        private static int count = 0;

        public Student(string name)
        {
            this.Name = name;
            count++;
        }

        public string Name { get => _name; set => _name = value; }

        public static int GetCount()
        {
            return count;
        }
    }
}
