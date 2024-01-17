using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4.Quiz
{
    internal class Jet: Vehicle
    {
        private static readonly string _vehicleType = "PrivateJet";

        [SetsRequiredMembers]
        public Jet(string noRegister, short year, double price, double tax, short seat, DateTime transactionDate, double rent, double driver, double orderPerHourse)
            : base(noRegister, year, price, tax, seat, transactionDate)
        {
            Rent = rent;
            Driver = driver;
            OrderPerHourse = orderPerHourse;
            base.Total = Rent + Driver ;
            base.VehicleType = _vehicleType;
            base.NoRegister = noRegister;
        }


        public double Rent { get; set; }
        public double Driver { get; set; }
        public double OrderPerHourse { get; set; }

    }
}
