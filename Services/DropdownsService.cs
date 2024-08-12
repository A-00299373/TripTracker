using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.Services
{
    public class DropdownsService
    {
        private readonly DatabaseContext _context;
        public DropdownsService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<LocationCategory[]> GetLocationCategoriesAsync()
        {
            return (await _context.GetAllAsync<LocationCategory>()).ToArray();
        }

        public string[] GetTripStatuses() => Enum.GetNames<TripStatus>();

        public async Task<string[]> GetExpenseCategoriesAsync() =>
            (await _context.GetAllAsync<ExpenseCategory>())
            .Select(c => c.Name)
            .ToArray();
    }
}

