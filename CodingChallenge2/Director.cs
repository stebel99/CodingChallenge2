using System.Collections.Generic;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;
using CodingChallenge2.Models;

namespace CodingChallenge2
{
    public class Director
    {
        private Director() { }

        private ClassRoom _classRoom;

        private static Dialog _dialog;

        private static Director _instance;

        public static Director GetInstance()
        {
            if (_instance == null)
            {
                _dialog = new Dialog();
                _instance = new Director();
            }
            return _instance;
        }

        public void StartStandartFlow()
        {
            _classRoom = new ClassRoom();

            int numberOfStudents = _dialog.AskNumberOfStudents();
            int numberOfTests = _dialog.AskNumberOfTests();

            BuildStudentsAndTests(numberOfStudents, numberOfTests);
        }

        private void BuildStudentsAndTests(int students, int tests)
        {
            for (int i = 0; i < students; i++)
            {
                string firstName = _dialog.AskFirstName();
                string lastName = _dialog.AskLastName();

                Student student = new Student(firstName, lastName);

                for (int j = 0; j < tests; j++)
                {
                    int gradeOfTest = _dialog.AskTestGrade(j + 1);
                    Test test = new Test(gradeOfTest);
                    student.Tests.Add(test);
                }

                student.CountGrade();
                _classRoom.Students.Add(student);
            }
        }

        public void ShowStudents()
        {
            _dialog.ShowStudents(_classRoom);
        }
    }
}