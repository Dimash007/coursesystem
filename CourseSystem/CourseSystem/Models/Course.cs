using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? DirectionId { get; set; }
        public Direction Direction { get; set; }
        public int? UserId { get; set; }
        public User user { get; set; }
    }
}
