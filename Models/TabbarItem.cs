using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.Models
{
    public readonly record struct TabbarItem(string Icon, Action OnTap)
    {
    }
}
