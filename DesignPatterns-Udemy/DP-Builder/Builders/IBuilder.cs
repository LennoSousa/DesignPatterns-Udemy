using DP_Builder.Components;
using DP_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Builders
{
    internal interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetAirBags(int airBags);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
    }
}
