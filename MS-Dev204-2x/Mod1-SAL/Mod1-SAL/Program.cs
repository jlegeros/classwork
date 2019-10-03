using System;

namespace Mod1SAL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*  In the Main() method of Program.cs:

                Instantiate a UProgram object called Information Technology.
                Instantiate three Student objects.
                Instantiate a Course object called Programming with C#.
                Add your three students to this Course object.
                Instantiate at least one Teacher object.
                Add that Teacher object to your Course object.
                Instantiate a Degree object, such as Bachelor.
                Add your Course object to the Degree object.
                Instantiate a UProgram object called Information Technology.
                Add the Degree object to the UProgram object.
                Using Console.WriteLine statements, output the following information to the console window:
                The name of the program and the degree it contains
                The name of the course in the degree
                The count of the number of students in the course.
            */
            var program = new UProgram("Information Technology");
            var student1 = new Student("Erica");
            var student2 = new Student("Tom");
            var student3 = new Student("Mary");
            var course = new Course("Programming with C#");

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            var teacher = new Teacher("Marco");

            course.AddTeacher(teacher);

            var degree = new Degree("Bachelor");

            degree.AddCourse(course);

            program.AddDegree(degree);

            Console.WriteLine($"{program.Name} contains {program.GetDegrees()}");
            Console.WriteLine($"{degree.Name} contains {degree.GetCourses()}");
            Console.WriteLine($"There are {course.GetStudentCount()} students enrolled in {course.Name}.");
        }
    }
}
