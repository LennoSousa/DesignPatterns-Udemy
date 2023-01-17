using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod.Vehicles
{
    internal class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a refeição!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega.");
        }
    }
}
