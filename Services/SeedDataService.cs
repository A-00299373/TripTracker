using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTracker.Data;

namespace TripTracker.Services
{
    public class SeedDataService
    {
        private readonly DatabaseContext _context;

        public SeedDataService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task SeedDataAsync()
        {

            //var foodCategory = await _context.FindAsync<ExpenseCategory>("Food");

            //if (foodCategory is null)
            //    return;

            var expenseCategories = new List<ExpenseCategory>
            {
                new("Food"), new("Fuel"), new("Entertainment"), new("Shopping"), new("Others")
            };

            var locationCategories = new List<LocationCategory>
            {
                new LocationCategory("Beach", "/images/chair.png"),
                new LocationCategory("Architecture and city", "/images/architecture-and-city.png"),
                new LocationCategory("Conservation", "/images/conservation.png"),
                new LocationCategory("Island", "/images/island.png"),
                new LocationCategory("Mountain", "/images/mountain.png"),
                new LocationCategory("Religeous", "/images/pray.png"),
                new LocationCategory("Other", "/images/travel.png")
            };

            foreach(var location in locationCategories)
            {
                //await _context.AddItemAsync<LocationCategory>(location);
                var existingLocation = await _context.FindAsync<LocationCategory>(location.Name);
                if (existingLocation == null)
                {
                    await _context.AddItemAsync(location);
                }
            }

            foreach (var expense in expenseCategories)
            {
                //await _context.AddItemAsync<ExpenseCategory>(expense);
                var existingExpense = await _context.FindAsync<ExpenseCategory>(expense.Name);
                if (existingExpense == null)
                {
                    await _context.AddItemAsync(expense);
                }
            }
        }
    }
}
