// See https://aka.ms/new-console-template for more information


using CSharpDesignPatterns;

var collection = new DaysInMonthCollection();
foreach (var monthWithDays in collection)
{
    Console.WriteLine($"{monthWithDays.Date} - {monthWithDays.Days}");
}
