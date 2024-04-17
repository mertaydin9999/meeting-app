using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alani zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alani zorunlu")]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Hatali email")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Ad alani zorunlu")]
        public bool WillAttend { get; set; }

    }
}