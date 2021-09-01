using System;

namespace CodingChallenge2
{
    static class Program
    {
        static void Main()
        {
            Director director = Director.GetInstance();
            
            director.StartStandartFlow();
            director.ShowStudents();

            Console.ReadLine();
        }
    }
}