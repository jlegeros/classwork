using System;
using System.Collections.Generic;

namespace Mod2SAL
{
    public class Degree
    {
        private string _name;
        private List<Course> _degreeCourses = new List<Course>();

        public Degree(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }

        public void AddCourse(Course course)
        {
            this._degreeCourses.Add(course);
        }

        public string GetCourses()
        {
            var output = "";
            foreach (var x in this._degreeCourses)
            {
                output += x.Name;
            }
            return output;
        }
    }
}
