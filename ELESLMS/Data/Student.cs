using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELESLMS.Data
{
    public class Student : User
    {
        [Required]
        public int Number { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
