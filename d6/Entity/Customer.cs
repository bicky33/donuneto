using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Entity
{
    internal class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }

        public override string ToString()
        {
            return $"{CustomerID} - {ContactName} - {CompanyName} - {ContactTitle}";
        }
    }
}
