using System.ComponentModel.DataAnnotations;

namespace Portal.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(80)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Place { get; set; }
    }
}
