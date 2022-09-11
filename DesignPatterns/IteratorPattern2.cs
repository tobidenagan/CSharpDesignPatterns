namespace CSharpDesignPatterns.DesignPatterns
{
    public static class EnumerableExtensions
    {
        // call method on an enumerable, then specify the filter (where) and then
        // the transformation (select) you want
        public static IEnumerable<TResult> FilteredSelect<T, TResult>(
            this IEnumerable<T> enumerable, Func<T, bool> filter,
            Func<T, TResult> fieldSelector)
        {
            foreach (var a in enumerable)
                if (filter(a)) yield return fieldSelector(a);
        }
    }

    class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }
    class OrderCollection
    {
        public IEnumerable<Orders> Orders { get; set; }
    }
}
