using System;
using System.Collections.Generic;

namespace Mod2SAL
{
    public class Course
    {
        private string _name;
        private List<Student> _enrolledStudents = new List<Student>();
        private List<Teacher> _courseTeachers = new List<Teacher>();

        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }

        public void AddStudent(Student student)
        {
            this._enrolledStudents.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this._courseTeachers.Add(teacher);
        }

        public int GetStudentCount()
        {
            return _enrolledStudents.Count;
        }
    }
}
