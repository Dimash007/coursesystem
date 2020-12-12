using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSystem.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public User user { get; set; }
    }
}
