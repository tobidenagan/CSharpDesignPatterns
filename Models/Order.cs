using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProductNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
    public class OrderCollection
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
