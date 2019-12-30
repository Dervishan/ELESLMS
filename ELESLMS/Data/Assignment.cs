using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public string Definition { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        public int PointsPossible { get; set; }
        [InverseProperty("Assignment")]
        public ICollection<Grade> Grades { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
