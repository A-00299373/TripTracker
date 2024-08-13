using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

namespace TripTracker.Data
{
    /// <summary>
    /// Represents an expense record within the TripTracker application.
    /// This model includes details such as the unique identifier (Id), associated trip (TripId),
    /// purpose of the expense (For), amount spent (Amount), category of the expense (Category),
    /// and the date when the expense was made (SpentOn). It is used to track and manage
    /// financial data related to trips.
    /// </summary>
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public int TripId { get; set; }

        [Required, MaxLength(100)]
        public string For { get; set;}

        [Range(0.1, double.MaxValue, ErrorMessage = "Please enter valid amount.")]
        public double Amount { get; set; }

        [Required]
        public string Category { get; set; }
        public DateTime? SpentOn { get; set; }
    }
}
