using System;

namespace Mod2SAL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var program = new UProgram("Information Technology");
            var student1 = new Student("Erica", 14);
            var student2 = new Student("Tom", 15);
            var student3 = new Student("Mary", 16);
            var course = new Course("Programming with C#");

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            var teacher = new Teacher("Marco", 45);

            course.AddTeacher(teacher);

            var degree = new Degree("Bachelor");

            degree.AddCourse(course);

            program.AddDegree(degree);

            Console.WriteLine($"{program.Name} contains {program.GetDegrees()}");
            Console.WriteLine($"{degree.Name} contains {degree.GetCourses()}");
            Console.WriteLine($"There are {course.GetStudentCount()} students enrolled in {course.Name}.");
            Console.WriteLine(student1.Status());
            Console.WriteLine(student2.Status());
            Console.WriteLine(student3.Status());
            Console.WriteLine(teacher.Status());
        }
    }
}
