using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Shared
{
    public class Products
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public Categories CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }
    }
}
