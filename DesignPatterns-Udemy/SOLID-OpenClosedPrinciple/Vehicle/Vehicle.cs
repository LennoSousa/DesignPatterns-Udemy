using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosedPrinciple.Vehicle
{
    internal class Vehicle : IVehicle
    {
        protected string color { get; set; }
        protected int year { get; set; }
        protected double engine { get; set; }

        public Vehicle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
