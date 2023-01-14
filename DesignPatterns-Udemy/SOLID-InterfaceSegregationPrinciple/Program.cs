using SOLID_InterfaceSegregationPrinciple.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2023, 600);

            Console.ReadLine();
        }
    }
}
