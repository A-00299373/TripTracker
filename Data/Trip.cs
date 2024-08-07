using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;


namespace TripTracker.Data
{
    /// <summary>
    /// Represents a trip in the TripTracker application.
    /// This model includes comprehensive details such as the unique identifier (Id),
    /// title of the trip (Title), location (Location), category image (CategoryImage),
    /// and various dates related to the trip (FromDate, ToDate, AddedOn, ModifiedOn).
    /// Additionally, it tracks the trip's status (Status) to indicate whether it is planned,
    /// ongoing, completed, or canceled. This class is fundamental for managing trip-related
    /// information within the app.
    /// </summary>
    public class Trip
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Required, MaxLengthAttribute(30)]
        public string Title { get; set; }

        [Required, MaxLengthAttribute(50)]
        public string Location { get; set; }

        [Required, MaxLength(30)]
        public string CategoryImage { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        //public TripStatus Status { get; set; } = TripStatus.Planned;

        private TripStatus _status = TripStatus.Planned;
        public TripStatus Status
        {
            get => _status;
            set
            {
                DisplayStatus = value.ToString();
                _status = value;
            }

        }

        [Ignore]
        public string DisplayStatus { get; set; }
    }
}
