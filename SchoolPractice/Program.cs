using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Sung";
            student.NumberOfCredits = 1;
            student.Gpa = 4.0;

            Console.WriteLine(student.Name);
        }
    }
}
