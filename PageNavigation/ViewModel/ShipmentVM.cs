using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Page_Navigation_App.Model;
using PageNavigation.Messages;
using PageNavigation.Model;
using System.Collections.ObjectModel;

namespace Page_Navigation_App.ViewModel
{
    partial class ShipmentVM : ObservableRecipient, IRecipient<OrderSubmittedMessage>
    {
        private readonly PageModel _pageModel;
        
        [ObservableProperty]
        private TimeOnly _shipmentTracking;

        [ObservableProperty]
        public ObservableCollection<OrderModel> _items;


        public ShipmentVM()
        {
            _pageModel = new();
            ShipmentTracking = TimeOnly.FromDateTime(DateTime.Now);

            Items = new();

            addOrder("Jones", 1000);
            addOrder("Brown", 2000);
            addOrder("Green", 3000);

            StrongReferenceMessenger.Default.Register<OrderSubmittedMessage>(this);
        }

        public void Receive(OrderSubmittedMessage message)
        {
            Items.Add(message.Value);
        }

        private void addOrder(string customer, int value)
        {
            Items.Add(new OrderModel { Customer = customer, Value = value });
        }
    }
}
