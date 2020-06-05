using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double qualityScore = this.Gpa * this.NumberOfCredits;
            double newQualityScore = qualityScore + grade;
            Gpa = newQualityScore / (this.NumberOfCredits + courseCredits);
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            string gradeLevel;
            if (0 <= credits && credits <= 29)
            {
                gradeLevel = "Freshman";
            }
            else if (30 <= credits && credits <= 59)
            {
                gradeLevel = "Sophomore";
            }
            else if (60 <= credits && credits <= 89)
            {
                gradeLevel = "Junior";
            }
            else if (90 <= credits)
            {
                gradeLevel = "Senior";
            }
            else
            {
                gradeLevel = "You're not a student";
            }

            return gradeLevel;
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
