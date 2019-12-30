using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [InverseProperty("Role")]
        public ICollection<User> Users { get; set; }
    }
}
