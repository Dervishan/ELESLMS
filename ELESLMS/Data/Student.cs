using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELESLMS.Data
{
    public class Student : User
    {
        public Student()
        {
            RoleId = 2;
        }
        [Required]
        public int Number { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
