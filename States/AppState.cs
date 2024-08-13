//using AudioUnit;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.States
{
    public class AppState : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedMenuItem { get; private set; } = AppConstants.MenuItems.Home;
        

        private string _innerPageTitle = string.Empty;
        public string InnerPageTitle 
        {
            get => _innerPageTitle;
            private set
            {
                _innerPageTitle = value;
                Notify();
                Notify(nameof(PageTitle));
            } 
        }

        public TabbarItem[] TabbarItems { get; set; } = Array.Empty<TabbarItem>();

        public void AddTabbarItems(params TabbarItem[] tabbarItems)
        {
            TabbarItems = tabbarItems;
            Notify(nameof(TabbarItems));
        }

        public void NoTabbarItems() => AddTabbarItems(Array.Empty<TabbarItem>());

        public string PageTitle => !string.IsNullOrEmpty(InnerPageTitle) ? InnerPageTitle : SelectedMenuItem switch
        {
            AppConstants.MenuItems.Home => AppConstants.AppName,
            _ => SelectedMenuItem
        };

        public void SetSelectedMenuItem(string pageName)
        {
            SelectedMenuItem = pageName;
            //SelectedMenuItemChanged?.Invoke(this, pageName);
            Notify(nameof(SelectedMenuItem));
            Notify(nameof(PageTitle));
        }

        public void SetInnerPageTitle(string pageTitle)
        {
            InnerPageTitle = pageTitle;
        }

        private void Notify([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
