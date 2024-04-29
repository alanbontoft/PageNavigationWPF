using CommunityToolkit.Mvvm.Messaging.Messages;
using PageNavigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigation.Messages
{
    internal class OrderSubmittedMessage : ValueChangedMessage<OrderModel>
    {
        public OrderSubmittedMessage(OrderModel value) : base(value)
        {
        }
    }
}
