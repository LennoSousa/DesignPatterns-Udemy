using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosedPrinciple.Vehicle
{
    class Car : Vehicle
    {
        private int seats { get; set; }
        private int doors { get; set; }

        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            this.seats = seats;
            this.doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} assentos.");
            StartVehicle();
        }
    }
}
