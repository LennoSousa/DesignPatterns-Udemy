using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosedPrinciple
{
    //Classe que não respeita o OCP.
    internal class Vehiclee
    {
        private string color { get; set; }
        private int year { get; set; }
        private double engine { get; set; }
        private int seats { get; set; }
        private int doors { get; set; }

        public Vehiclee(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} assentos.");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {year}, {engine} cilindradas.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
