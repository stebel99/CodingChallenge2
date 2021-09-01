using System.Collections.Generic;

namespace CodingChallenge2.Models
{
    public class ClassRoom
    {
        public ICollection<Student> Students { get; set; }

        public ClassRoom()
        {
            Students = new List<Student>();
        }
    }
}