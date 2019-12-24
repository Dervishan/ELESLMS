using System;
using System.Collections.Generic;
using System.Text;

namespace ELESLMS.Data
{
    public class Teacher : User
    {
        public Teacher()
        {
            RoleId = 3;
        }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
