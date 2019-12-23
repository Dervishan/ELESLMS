using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ELESLMS.Data
{
    public class User
    {
        public User()
        {
            IsDeleted = false;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "İsim minimum 2, maksimum 20 karakter olmalıdır.", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Soyisim minimum 2, maksimum 15 karakter olmalıdır.", MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Kullanıcı adı minimum 5, maksimum 15 karakter olmalıdır.", MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EMail { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedTime { get; set; }
        public DateTime LastLogin { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
