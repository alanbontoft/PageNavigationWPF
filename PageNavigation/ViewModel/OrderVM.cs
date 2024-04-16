using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class OrderVM : ObservableObject
    {
        private readonly PageModel _pageModel;

        [ObservableProperty]
        private DateOnly _displayOrderDate;
   

        public OrderVM()
        {
            _pageModel = new();
            DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
