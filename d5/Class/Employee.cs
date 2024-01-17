using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5.Class
{
    internal class Employee
    {
        public required int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[]? Photo { get; set; }
        public string? Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public Location Location { get; set; }
        public override string ToString()
        {
            return $"EmployeeId: {EmployeeID}, FirstName: {FirstName}, LastName: {LastName}, " +
                $"TitleOfCourtesy: {TitleOfCourtesy}, BirthDate: {BirthDate}, HireDate: {HireDate}, " +
                $"HomePhone: {HomePhone}, Extension: {Extension}, Photo: {Photo}, " +
                $"Notes: {Notes}, ReportsTo: {ReportsTo}, PhotoPath: {PhotoPath}, " +
                $"Location: {Location}";
        }
    }
}
