using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Class
{
    internal class Supplier
    {
        public int SupplierID { get; set; }
        public ContactPerson ContactPerson { get; set; }
        public Location Location { get; set; }

        public string HomePage { get; set; }

        public override string ToString()
        {
            return $"SupplierID: {SupplierID}, ContactPerson: {ContactPerson}, Location: {Location}, HomePage: {HomePage}";
        }
    }
}
