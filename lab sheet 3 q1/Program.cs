using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_3_q1

{
    public class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string CourseName
        {
            get { return courseName; }
        }

        public double Grade
        {
            get { return grade; }
        }

        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            this.SetInstructorName(instructorName);
            this.SetGrade(grade);
        }
            public void SetInstructorName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Instructor name cannot be empty or null");
            }
            instructorName = name;
        }

        private void SetGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException("Grade must be between 0 and 100");
            }
            this.grade = grade;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instructor Name: {instructorName}");
            Console.WriteLine($"Letter Grade: {CalculateLetterGrade()}");
        }
    }
}
