using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Entities
{
    [Table("Users")]
    public class User
    {
        //[Key]
        //[Required]
        //[MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(50)]
        public string Firstname { get; set; }
        public string Password { get; set; }

        [MaxLength(50)]
        public string Lastname { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string MailId { get; set; }

        public int UserType { get; set; }
        public int userid { get; set; }
    }
}
