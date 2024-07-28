using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.Models
{
    /// <summary>
    /// Represents the data required for a user to sign in to the TripTracker application.
    /// This model includes the user's username and password, which are validated
    /// during the sign-in process. It is essential for authentication and secure access
    /// to the app's features.
    /// </summary>
    public class SigninModel
    {
        [Required, MaxLength(20)]
        public string Username { get; set; }

        [Required, MaxLength(20)]
        public string Password { get; set; }
    }
}