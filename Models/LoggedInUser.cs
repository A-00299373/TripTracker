﻿using System.Text.Json;

namespace TripTracker.Models
{
    /// <summary>
    /// Represents a logged-in user within the TripTracker application.
    /// This model includes the user's unique identifier (Id) and their display
    /// name (Name). It provides basic user information needed for session
    /// management and personalization features within the app.
    /// </summary>

    public readonly record struct LoggedInUser(int Id, string Name)
    {
        public string ToJson() => JsonSerializer.Serialize(this);

        public static LoggedInUser LoadFromJson(string? json) =>
            string.IsNullOrWhiteSpace(json)
            ? default
            : JsonSerializer.Deserialize<LoggedInUser>(json);
    }
}
