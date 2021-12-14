using System.ComponentModel.DataAnnotations;

namespace SampleApp.Models
{
    public class ForUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Gender? Gender { get; set; }

    }
    public enum Gender
    {
       Male,Female
    }

    
}
