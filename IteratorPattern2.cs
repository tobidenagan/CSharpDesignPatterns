    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
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
}
