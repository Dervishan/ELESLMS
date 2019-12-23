using System;
using System.Collections.Generic;
using System.Text;

namespace ELESLMS.Data
{
    public class Teacher : User
    {
        public ICollection<Course> Courses { get; set; }
    }
}
