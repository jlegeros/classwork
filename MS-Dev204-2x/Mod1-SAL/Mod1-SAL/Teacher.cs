using System;
namespace Mod1SAL
{
    public class Teacher
    {
        private string _name;

        public Teacher(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
