using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.States
{
    public class AppState
    {
        public event EventHandler<string> SelectedMenuItemChanged;
        public string SelectedMenuItem { get; private set; } = AppConstants.MenuItems.Home;
        public string PageTitle => SelectedMenuItem switch
        {
            AppConstants.MenuItems.Home => AppConstants.AppName,
            _ => SelectedMenuItem
        };

        public void SetSelectedMenuItem(string pageName)
        {
            SelectedMenuItem = pageName;
            SelectedMenuItemChanged?.Invoke(this, pageName);
        }
    }
}
