using System.ComponentModel.DataAnnotations;

namespace GymApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
