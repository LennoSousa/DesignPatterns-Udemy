using DP_FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod.Factories
{
    internal class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
