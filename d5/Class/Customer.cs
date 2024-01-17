using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Class
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public ContactPerson ContactPerson { get; set; }
        public Location Location { get; set; }
        public override string ToString()
        {
            return $"CustomerID: {CustomerID}, ContactPerson: {ContactPerson}, Location: {Location}";
        }
    }
}
