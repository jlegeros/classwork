using System;
using System.Collections.Generic;
namespace Mod1SAL
{
    public class UProgram
    {
        private string _name;
        private List<Degree> _programDegrees = new List<Degree>();

        public UProgram(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }

        public void AddDegree(Degree degree)
        {
            this._programDegrees.Add(degree);
        }

        public string GetDegrees()
        {
            var output = "";
            foreach (var x in this._programDegrees)
            {
                output += x.Name;
            }
            return $"{output} degree.";
        }
    }
}
