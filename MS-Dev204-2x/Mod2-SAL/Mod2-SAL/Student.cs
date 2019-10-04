using System;
namespace Mod2SAL
{
    public class Student : Person
    {
        private static int count = 0;

        public Student(string name, int age) : base(name, age)
        {
            count++;
        }

        public override string Status()
        {
            return $"{this.Name} age {this.Age} goes to the school";
        }

        public static int GetCount()
        {
            return count;
        }
    }
}
