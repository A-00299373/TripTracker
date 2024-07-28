using System.ComponentModel.DataAnnotations;

namespace TripTracker.Models
{
    /// <summary>
    /// Represents the data required for a new user to sign up for the TripTracker application.
    /// This model includes the user's name, username, and password. It is used during
    /// the registration process to create a new account in the system, ensuring that
    /// all necessary information is collected and validated.
    /// </summary>
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