using CommunityToolkit.Mvvm.ComponentModel;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    partial class SettingVM : ObservableObject
    {
        private readonly PageModel _pageModel;
        
        [ObservableProperty]
        private bool _settings;

        public SettingVM()
        {
            _pageModel = new();
            Settings = true;
        }
    }
}
