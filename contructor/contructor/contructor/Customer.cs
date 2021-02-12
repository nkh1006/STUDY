using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Contructor
        // ctor + tab + tab

        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overload
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
