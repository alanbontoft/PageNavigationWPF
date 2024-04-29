using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.Model
{
    partial class OrderModel : ObservableObject
    {
        [ObservableProperty]
        private string? _customer;

        [ObservableProperty]
        private int? _value;
    }
}
