using SQLite;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;


namespace TripTracker.Data
{
    /// <summary>
    /// Represents a category for expenses within the TripTracker application.
    /// This model includes the category's unique identifier (Name) and is used
    /// to classify expenses, allowing for better organization and tracking.
    /// It helps users categorize their spending for more detailed financial reporting.
    /// </summary>
    public class ExpenseCategory
    {
        public ExpenseCategory(string name)
        {
            Name = name;
        }

        public ExpenseCategory()
        {

        }

        [PrimaryKey, MaxLengthAttribute(100)]
        public string Name{ get; set; }
    }
}
