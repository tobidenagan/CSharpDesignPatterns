using CSharpDesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.DesignPatterns
{
    public class OrderItemViewModel2 : Order, IOrderItemViewModel
    {
        public OrderItemViewModel2(IEnumerable<Order> orders, Order o)
        {
            base.Id  = o.Id;
            base.FirstName  = o.FirstName;
            base.LastName  = o.LastName;
            base.ProductNumber  = o.ProductNumber;
            base.OrderDate  = o.OrderDate;
            PreviousOrderDates = string.Join("\n",
                orders.FilteredSelect(x => x.Id < 2, x => x.OrderDate.ToString("d")));
        }
        public int CustomerId => base.Id;
        public string CustomerName => base.FirstName + " " + base.LastName;
        public new string OrderDate => base.OrderDate.ToString("d");
        public string PreviousOrderDates { get; private set; }
    }

    public class OrderListViewModel2
    {
        public IEnumerable<IOrderItemViewModel> orders { get; set; }
    }
    public interface IOrderItemViewModel
    {
        int CustomerId { get; }
        string CustomerName { get; }
        string OrderDate { get; }
        string PreviousOrderDates { get; }
    }
}
