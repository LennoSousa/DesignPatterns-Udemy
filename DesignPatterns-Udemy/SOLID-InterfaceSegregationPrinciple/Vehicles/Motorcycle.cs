using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_InterfaceSegregationPrinciple.Vehicles
{
    internal class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorCycle(color, year, engine);
        }

        public void ConfigureMotorCycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma moto ano {year}, motor {engine}, da cor {color}.");

            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores.");
        }
    }
}
