using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4.Quiz
{
    internal class Vehicle
    {

        public required string NoRegister { get; set; }
        public required string VehicleType { get; set; }
        public short Year { get; set; }
        public double Price { get; set; }   
        public double Tax { get; set; }
        public short Seat { get; set; }
        public DateTime TransactionDate { get; set;}
        public double Total { get; set; }

        [SetsRequiredMembers]
        public Vehicle(string noRegister, string vehicleType, short year, double price, double tax, short seat, DateTime transactionDate, double total)
        {
            NoRegister = noRegister;
            VehicleType = vehicleType;
            Year = year;
            Price = price;
            Tax = tax;
            Seat = seat;
            TransactionDate = transactionDate;
            Total = total;
        }

        public Vehicle(string noRegister, short year, double price, double tax, short seat, DateTime transactionDate)
        {
            NoRegister = noRegister;
            Year = year;
            Price = price;
            Tax = tax;
            Seat = seat;
            TransactionDate = transactionDate;
        }

        public override string ToString()
        {
            return $"NoRegister: {NoRegister}, VehicleType: {VehicleType}, Year: {Year}, Price: {Price}, Tax: {Tax}, Seat: {Seat}, TransactionDate: {TransactionDate}, Total: {Total}";
        }
    }
}
