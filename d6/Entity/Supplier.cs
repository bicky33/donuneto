using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Entity
{
    internal class Supplier
    {
        public int SupplierID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public override string ToString()
        {
            return $"{SupplierID} - {ContactName} - {CompanyName} - {ContactTitle}";
        }
    }
}
