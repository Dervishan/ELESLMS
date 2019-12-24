using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string Name { get; set; }
        public bool IsApproved { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
