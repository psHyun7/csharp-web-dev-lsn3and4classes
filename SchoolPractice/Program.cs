using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student student1 = new Student("Adam");
            Student student2 = new Student("Adam", 1, 6, 3.75);
            student1.AddGrade(3, 3.5);
            student1.AddGrade(3, 4);
            Student student3 = new Student("Steve", 10, 72, 3.13);

            Teacher teacher1 = new Teacher("Sam", "Smith", "Mathematics", 15);

            Course math101 = new Course();
            math101.Topic = "Mathematics";
           

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student3.ToString());
            Console.WriteLine(math101.ToString());
        }
    }
}
