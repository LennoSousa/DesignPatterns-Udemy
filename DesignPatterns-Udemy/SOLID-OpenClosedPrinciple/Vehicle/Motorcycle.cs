using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosedPrinciple.Vehicle
{
    internal class Motorcycle : Vehicle
    {
        private int seats { get; set; }
        private int doors { get; set; }

        public Motorcycle(string color, int year, double engine) : base (color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilindradas.");
            StartVehicle();
        }

    }
}
