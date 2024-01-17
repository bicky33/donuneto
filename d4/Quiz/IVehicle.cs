using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4.Quiz
{
    enum VehicleType
    {
        SUV,
        TAXI,
        PrivateJet
    }

    interface IVehicle
    {
        int GetTotalVehicle();
        int GetTotalVehicle(VehicleType vehicleType);
        double GetTotalIncomeVechicle(VehicleType vehicleType);
        double GetTotalIncomeVechicle();
    }

    class IVehicleImpl : IVehicle
    {
        private List<Vehicle> _vehicles;

        public IVehicleImpl(List<Vehicle> vehicles)
        {
            _vehicles = vehicles;
        }

        public int GetTotalVehicle()
        {
            return _vehicles.DistinctBy(v => v.NoRegister).Count();
        }

        public int GetTotalVehicle(VehicleType vehicleType)
        {
            return _vehicles.DistinctBy(v => v.NoRegister).Where(v => v.VehicleType == vehicleType.ToString()).Count();
        }

        public double GetTotalIncomeVechicle(VehicleType vehicleType)
        {
            return _vehicles.Where(v => v.VehicleType == vehicleType.ToString()).Sum(v => v.Total);
        }

        public double GetTotalIncomeVechicle()
        {
            return _vehicles.Sum(v => v.Total);
        }
    }
}
