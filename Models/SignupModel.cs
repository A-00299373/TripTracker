using System.ComponentModel.DataAnnotations;

namespace TripTracker.Models
{
    public class SignupModel
    { 
        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Username { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }

    }
}