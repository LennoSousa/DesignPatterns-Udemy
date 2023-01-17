using DP_AbstractFactory.Aircrafts;
using DP_AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Factories
{
    internal interface ITransportFactory
    {
        IAirCraft CreateTransportAircraft();
        ILandVehicle CreateTransportVehicle();
    }
}
