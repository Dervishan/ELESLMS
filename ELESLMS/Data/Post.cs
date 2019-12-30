using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =5)]
        public string Header { get; set; }
        [Required]
        public string Content { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }
}
