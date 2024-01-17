using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.Entity
{
    internal class Employee
    {
        public long EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, LastName: {LastName}, FirstName: {FirstName}, " +
                $"Title: {Title}, TitleOfCourtesy: {TitleOfCourtesy}, BirthDate: {BirthDate}, " +
                $"HireDate: {HireDate}";
        }
    }
}
