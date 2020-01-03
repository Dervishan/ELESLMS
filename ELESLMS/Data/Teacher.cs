using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Teacher : User
    {
        public Teacher() : base()
        {
            RoleId = 3;
        }
        public string Subject { get; set; }
        [InverseProperty("Teacher")]
        public ICollection<Course> Courses { get; set; }
    }
}
