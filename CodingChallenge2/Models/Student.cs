using System.Collections.Generic;
using CodingChallenge2.Enums;
using CodingChallenge2.Helpers;

namespace CodingChallenge2.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int AverageGrade { get; set; }

        public GradeType AverageGradeType { get; set; }

        public ICollection<Test> Tests { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Tests = new List<Test>();
        }

        public Student()
        {
            Tests = new List<Test>();
        }

        public void CountGrade()
        {
            foreach (Test test in Tests)
            {
                AverageGrade += test.NumericalGrade;
            }

            AverageGrade /= Tests.Count;
            AverageGradeType = AverageGrade.ConvertToEnum();
        }
    }
}