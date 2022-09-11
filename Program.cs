// See https://aka.ms/new-console-template for more information


using CSharpDesignPatterns;
using CSharpDesignPatterns.DesignPatterns;
using CSharpDesignPatterns.Models;
using Microsoft.Extensions.Logging;

#region IteratorPattern1
//var collection = new DaysInMonthCollection();
//foreach (var monthWithDays in collection)
//{
//    Console.WriteLine($"{monthWithDays.Date} - {monthWithDays.Days}");
//}
#endregion

#region IteratorPattern2
//var orders = new List<Order>
//{
//    new Order
//    {
//        Id = 1,
//        OrderDate = new DateTime(2000, 3, 3),
//        FirstName = "Orange",
//        ProductNumber = "PRD1"
//    },
//    new Order
//    {
//        Id = 2,
//        OrderDate = new DateTime(2002, 3, 3),
//        FirstName = "Apple",
//        ProductNumber = "PRD2"
//    }
//};

//var filteredOrders = orders.FilteredSelect(x => x.Id > 1,x => x.Id + " " + x.FirstName + " " + x.ProductNumber);

//foreach (var order in filteredOrders)
//{
//    Console.WriteLine($"{order}");
//}
#endregion

#region FactoryPattern
//var notificationServiceProvider = new NotificationServiceProvider();
//var shippingService = new ShippingService(notificationServiceProvider);
//shippingService.ShipItem();
#endregion

#region AdapterPattern
//var logger = new FileLogger<Program>("Log.txt");
//logger.LogInformation("This is a new log message");
#endregion

#region AdapterPattern2
var orders = new List<Order>
{
    new Order
    {
        Id = 1,
        OrderDate = new DateTime(2000, 3, 3),
        FirstName = "Tobi",
        LastName = "D",
        ProductNumber = "PRD1"
    },
    new Order
    {
        Id = 2,
        OrderDate = new DateTime(2002, 3, 3),
        FirstName = "Henry",
        LastName = "Smith",
        ProductNumber = "PRD2"
    }
};
var filteredOrders = orders.Select(x => new OrderItemViewModel(orders, x));

foreach (var order in filteredOrders)
{
    Console.WriteLine($"{order.CustomerId} {order.CustomerName} {order.OrderDate} {order.PreviousOrderDates}");
}
#endregion
