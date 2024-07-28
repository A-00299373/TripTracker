using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.Data
{
    /// <summary>
    /// Represents a user in the TripTracker system.
    /// This model includes the user's unique identifier (Id), name (Name),
    /// username (Username), and password (Password). It is used for managing
    /// user information, authentication, and access control within the app.
    /// </summary>
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
