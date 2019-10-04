using System;
namespace Mod2SAL
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Status()
        {
            return $"{this.Name} teaches at the school";
        }
    }
}
