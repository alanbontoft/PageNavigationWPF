using Page_Navigation_App.Utilities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Page_Navigation_App.ViewModel
{
    partial class NavigationVM : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;


        [RelayCommand] private void Home(object obj) => CurrentView = new HomeVM();
        [RelayCommand] private void Customers(object obj) => CurrentView = new CustomerVM();
        [RelayCommand] private void Products(object obj) => CurrentView = new ProductVM();
        [RelayCommand] private void Orders(object obj) => CurrentView = new OrderVM();
        [RelayCommand] private void Transactions(object obj) => CurrentView = new TransactionVM();
        [RelayCommand] private void Shipments(object obj) => CurrentView = new ShipmentVM();
        [RelayCommand] private void Settings(object obj) => CurrentView = new SettingVM();

        public NavigationVM()
        {
            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
