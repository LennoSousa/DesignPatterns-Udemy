using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Aircrafts
{
    internal interface IAirCraft
    {
        void CheckWind();
        void StartRoute();
        void GetCargo();
    }
}
