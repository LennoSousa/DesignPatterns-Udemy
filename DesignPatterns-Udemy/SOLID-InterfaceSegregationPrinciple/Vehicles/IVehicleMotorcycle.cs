using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_InterfaceSegregationPrinciple.Vehicles
{
    internal interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorCycle(string color, int year, double engine);
    }
}
