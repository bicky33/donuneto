﻿using d5.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Class
{
    internal class ContactPerson : IContactPerson
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
    }
}
