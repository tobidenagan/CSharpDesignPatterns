using CSharpDesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.DesignPatterns
{
    public class OrderItemViewModel
    {
        private Order order;
        public OrderItemViewModel(IEnumerable<Order> orders, Order adaptee)
        {
            order = adaptee;
            PreviousOrderDates = string.Join("\n",
                orders.FilteredSelect(x => x.Id < 2, x => x.OrderDate.ToString("d")));
        }
        public int CustomerId => order.Id;
        public string CustomerName => order.FirstName + " " + order.LastName;
        public string OrderDate => order.OrderDate.ToString("d");
        public string ProductNumber => order.ProductNumber;
        public string PreviousOrderDates { get; private set; }
    }

    public class OrderListViewModel
    {
        public IEnumerable<OrderItemViewModel> orders { get; set; }
    }
}
