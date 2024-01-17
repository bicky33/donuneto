using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Contract
{
    public interface ILocation
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
    }
}
