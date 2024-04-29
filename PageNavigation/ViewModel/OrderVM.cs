using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Page_Navigation_App.Model;
using PageNavigation.Messages;
using PageNavigation.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class OrderVM : ObservableObject
    {
        private readonly PageModel _pageModel;

        [ObservableProperty]
        private DateOnly _displayOrderDate;

        [ObservableProperty]
        private string? _customer;

        [ObservableProperty]
        private int? _value;


        public OrderVM()
        {
            _pageModel = new();
            DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);


            Customer = "Morgan";
            Value = 1000;
        }

        [RelayCommand]
        private void SubmitOrder()
        {
            var order = new OrderModel();

            order.Customer = Customer;
            order.Value = Value;

            var orderMessage = new OrderSubmittedMessage(order);

            StrongReferenceMessenger.Default.Send(orderMessage);

        }
    }
}
