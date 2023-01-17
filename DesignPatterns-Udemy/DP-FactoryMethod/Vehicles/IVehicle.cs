using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod.Vehicles
{
    internal interface IVehicle
    {
        void GetCargo();
        void StartRoute();
    }
}
