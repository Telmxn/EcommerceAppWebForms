using System.ComponentModel.DataAnnotations;

namespace EcommerceAppWebForms.Data.Entities
{
    public class User
    {
        public User()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50,MinimumLength =2)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [StringLength(maximumLength:30,MinimumLength =8)]
        public string Password { get; set; }
        public Role Role { get; set; }
    }
    public enum Role
    {
        User,
        Admin
    }
}