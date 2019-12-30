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
        public string Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime OpeningDate { get; set; }
        public bool IsApproved { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [InverseProperty("Course")]
        public IList<StudentCourse> StudentCourses { get; set; }
        [InverseProperty("Course")]
        public ICollection<Assignment> Assignments { get; set; }
    }
}
