using SQLite;

namespace TripTracker.Data
{
    /// <summary>
    /// Represents a category of locations within the TripTracker application.
    /// This model includes a unique identifier (Name) and an associated image (Image)
    /// that represents the category visually. It is used to classify locations
    /// related to trips, providing a more organized and user-friendly way to manage trip data.
    /// </summary>
    public class LocationCategory
    {
        [PrimaryKey]
        public string Name { get; set; }
        public string Image{ get; set; }

        public LocationCategory(string name, string image)
        {
            Name = name;
            Image = image;
        }

        public LocationCategory() 
        {
        
        }
    }
}
