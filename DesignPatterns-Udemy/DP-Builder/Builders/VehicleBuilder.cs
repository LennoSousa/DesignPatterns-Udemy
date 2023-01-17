using DP_Builder.Components;
using DP_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Builders
{
    internal class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetAirBags(int airBags)
        {
            vehicle.AirBags = airBags;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }
    }
}
