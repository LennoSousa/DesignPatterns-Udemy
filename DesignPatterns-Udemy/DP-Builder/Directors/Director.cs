using DP_Builder.Builders;
using DP_Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Directors
{
    internal class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUVCar()
        {
            builder.SetVehicleType(VehicleType.SUV);
            builder.SetEngine(new Engine(2600));
            builder.SetAirBags(6);
            builder.SetSeats(7);
            builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
        }
    }
}
