using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class CustomerVM : ObservableObject
    {
        private readonly PageModel _pageModel;

        [ObservableProperty]
        private int _customerID;

        public CustomerVM()
        {
            _pageModel = new();
            CustomerID = 100528;
        }
    }
}
