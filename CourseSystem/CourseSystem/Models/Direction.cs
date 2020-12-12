using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSystem.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Course> Courses { get; set; }
        public Direction()
        {
            Courses = new List<Course>();
        }
    }
}
