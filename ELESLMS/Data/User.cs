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
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Soyisim minimum 2, maksimum 15 karakter olmalıdır.", MinimumLength = 2)]
        [Display(Name = "Soyadı")]
        public string Surname { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Kullanıcı adı minimum 5, maksimum 15 karakter olmalıdır.", MinimumLength = 5)]
        [Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Şifre")]
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
