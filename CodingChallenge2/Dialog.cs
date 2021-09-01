using System;
using CodingChallenge2.Models;

namespace CodingChallenge2
{
    public class Dialog
    {
        public int AskNumberOfStudents()
        {
            Console.Write("Input the number od students: ");
            int numberOfStudents = Int32.Parse(Console.ReadLine() ?? "0");

            return numberOfStudents;
        }

        public int AskNumberOfTests()
        {
            Console.Write("Input the number od tests: ");
            int numberOfTests = Int32.Parse(Console.ReadLine() ?? "0");

            return numberOfTests;
        }

        public string AskFirstName()
        {
            Console.Write("Input the First name: ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        public string AskLastName()
        {
            Console.Write("Input the Last name: ");
            string lastName = Console.ReadLine();

            return lastName;
        }

        public int AskTestGrade(int numberOfTest)
        {
            Console.Write($"Input the Grade of test{numberOfTest}: ");
            int grade = Int32.Parse(Console.ReadLine() ?? "0");

            return grade;
        }

        public void ShowStudents(ClassRoom classRoom)
        {
            ShowFirstLine();

            foreach (Student student in classRoom.Students)
            {
                ShowStudentInfo(student);
            }
        }

        private void ShowFirstLine()
        {
            Console.WriteLine(@"|{0,12}  | {1,10}  |{2,7} |{3,7} |", "First Name", "Last Name", "Grade", "Letter");
        }

        private void ShowStudentInfo(Student student)
        {
            Console.WriteLine(@"|{0,12}  | {1,10}  |{2,7} |{3,7} |",
                student.FirstName,
                student.LastName,
                student.AverageGrade,
                student.AverageGradeType.ToString());
        }

    }
}