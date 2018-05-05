using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int OrderDate { get; set; }

        public int ShipCity { get; set; }

        public int ShipCountry { get; set; }

    }
}
