using CodingChallenge2.Enums;

namespace CodingChallenge2.Helpers
{
    public static class Extension
    {
        public static GradeType ConvertToEnum(this int number)
        {
            if (number <= 100 && number >= 90)
            {
                return GradeType.A;
            }
            else if (number <= 89 && number >= 80)
            {
                return GradeType.B;
            }
            else if (number <= 79 && number >= 70)
            {
                return GradeType.C;
            }
            else if (number <= 69 && number >= 60)
            {
                return GradeType.D;
            }
            else if (number <= 59 && number >= 0)
            {
                return GradeType.F;
            }
            else
            {
                return GradeType.Undefined;
            }
        }
    }
}