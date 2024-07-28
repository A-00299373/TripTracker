namespace TripTracker.Data
{
    /// <summary>
    /// Enumerates the possible statuses of a trip in the TripTracker application.
    /// The statuses include Planned, Ongoing, Completed, and Cancelled. This enumeration
    /// is used to track and manage the lifecycle of a trip, helping users understand
    /// the current state of their travel plans.
    /// </summary>
    public enum TripStatus
    {
        Planned = 0,
        Ongoing = 1,
        Completed = 2,
        Cancelled = -1,
    }
}
