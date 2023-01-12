using SOLID_OpenClosedPrinciple.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                Motorcycle vehicle = new Motorcycle("Branco", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
