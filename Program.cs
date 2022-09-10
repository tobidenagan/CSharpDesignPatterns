// See https://aka.ms/new-console-template for more information


using CSharpDesignPatterns;

#region IteratorPattern1
//var collection = new DaysInMonthCollection();
//foreach (var monthWithDays in collection)
//{
//    Console.WriteLine($"{monthWithDays.Date} - {monthWithDays.Days}");
//}
#endregion

#region IteratorPattern2
var orders = new List<Orders>
{
    new Orders
    {
        Id = 1,
        DateCreated = new DateTime(2000, 3, 3),
        Name = "Orange",
        ProductNumber = "PRD1"
    },
    new Orders
    {
        Id = 2,
        DateCreated = new DateTime(2002, 3, 3),
        Name = "Apple",
        ProductNumber = "PRD2"
    }
};

var filteredOrders = orders.FilteredSelect(x => x.Id > 1,x => x.Id + " " + x.Name + " " + x.ProductNumber);

foreach (var order in filteredOrders)
{
    Console.WriteLine($"{order}");
}
#endregion
