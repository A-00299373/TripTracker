using TripTracker.ViewModels;

namespace TripTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage(AppViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
