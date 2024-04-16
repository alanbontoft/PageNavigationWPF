using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class ShipmentVM : ObservableObject
    {
        private readonly PageModel _pageModel;
        
        [ObservableProperty]
        private TimeOnly _shipmentTracking;


        public ShipmentVM()
        {
            _pageModel = new();
            ShipmentTracking = TimeOnly.FromDateTime(DateTime.Now);
        }
    }
}
