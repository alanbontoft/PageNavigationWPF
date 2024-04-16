using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class ProductVM : ObservableObject
    {
        private readonly PageModel _pageModel;

        [ObservableProperty]
        private string _productAvailability;


        public ProductVM()
        {
            _pageModel = new();
            ProductAvailability = "Out of Stock";
        }
    }
}
