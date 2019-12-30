using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int StudentCourseId { get; set; }
        public StudentCourse StudentCourse { get; set; }
    }
}
