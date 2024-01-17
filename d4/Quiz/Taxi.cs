using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4.Quiz
{
    internal class Taxi : Vehicle
    {
        private static readonly string _vehicleType = "TAXI";

        [SetsRequiredMembers]
        public Taxi(string noRegister, short year, double price, double tax, short seat, DateTime transactionDate, short order, double orderPerKM)
            : base(noRegister, year, price, tax, seat, transactionDate)
        {
            Order = order;
            OrderPerKM = orderPerKM;
            base.Total = Order * OrderPerKM;
            base.VehicleType = _vehicleType;
            base.NoRegister = noRegister;
        }
        

        public short Order { get; set; }
        public double OrderPerKM { get; set; }
    }
}
