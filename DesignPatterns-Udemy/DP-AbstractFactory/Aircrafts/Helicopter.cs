using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Aircrafts
{
    internal class Helicopter : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok. Ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!!!");
        }
    }
}
