using SQLite;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;


namespace TripTracker.Data
{
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
