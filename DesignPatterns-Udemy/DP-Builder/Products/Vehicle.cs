using DP_Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder.Products
{
    internal class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private int airBags;
        private Engine engine;
        private Transmission transmission;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public int AirBags
        {
            get => airBags;
            set => airBags = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }
    }
}
