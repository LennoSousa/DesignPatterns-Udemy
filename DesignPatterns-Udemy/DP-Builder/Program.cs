using DP_Builder.Builders;
using DP_Builder.Directors;
using DP_Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");


            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {truck.VehicleType}");

            director.ConstructSUVCar();

            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {suv.VehicleType}");




            Console.ReadLine();
        }
    }
}
