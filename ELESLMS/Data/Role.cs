using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELESLMS.Data
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10,MinimumLength = 3)]
        public string Name { get; set; }
        public bool CanCreateCourses { get; set; }
        public bool CanDeleteCourses { get; set; }
        public bool CanCreateAssignments { get; set; }
        public bool CanDeleteAssignments { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
