using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class TransactionVM : ObservableObject
    {
        private readonly PageModel _pageModel;

        [ObservableProperty]
        private decimal _transactionAmount;


        public TransactionVM()
        {
            _pageModel = new();
            TransactionAmount = 5638;
        }
    }
}
