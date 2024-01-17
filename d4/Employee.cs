using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4
{
    internal class Employee
    {
        private int _empId;
        private string _firstName;
        private string _lastName;
        private DateTime _joinDate;
        private double _basicSalary;
        private double _totalSalary;

        public int EmpId { get => _empId; set => _empId = value;}
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime JoinDate { get => _joinDate; set => _joinDate = value; }

        public double BasicSalary { get => _basicSalary; set => _basicSalary = value; }

        public double TotalSalary { get => _totalSalary; set => _totalSalary = value; }

        public Employee(int empId, string firstName, string lastName, DateTime joinDate, double basicSalary, double totalSalary)
        {
            _empId = empId;
            _firstName = firstName;
            _lastName = lastName;
            _joinDate = joinDate;
            _basicSalary = basicSalary;
            _totalSalary = totalSalary;
        }
    }
}
