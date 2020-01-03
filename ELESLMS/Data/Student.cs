using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Student : User
    {
        public Student() : base()
        {
            RoleId = 2;
        }
        
        public string Number { get; set; }
        [InverseProperty("Student")]
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
