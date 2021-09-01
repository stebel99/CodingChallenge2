namespace CodingChallenge2.Models
{
    public class Test
    {
        public int NumericalGrade { get; set; }
        
        public Test(int grade)
        {
            if (grade > 100)
            {
                NumericalGrade = 100;
            }
            else if (grade < 0)
            {
                NumericalGrade = 0;
            }
            else
            {
                NumericalGrade = grade;
            }
        }
    }
}