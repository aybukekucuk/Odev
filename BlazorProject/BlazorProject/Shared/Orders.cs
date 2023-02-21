using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Orders
    {
        public int OrderID { get; set; }

        public Customers CustomerID { get; set; }

        public Employees EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }
    }
}
