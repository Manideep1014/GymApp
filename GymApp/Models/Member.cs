using System.ComponentModel.DataAnnotations;

namespace GymApp.Models
{
    public class Member
    {
        [Key]
        public int MemberId {  get; set; }
        public string MemberName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }   
        public DateTime MembershipExpiry { get; set; }
        public DateTime DOJ {  get; set; }  
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
