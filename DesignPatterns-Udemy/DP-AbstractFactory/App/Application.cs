using DP_AbstractFactory.Aircrafts;
using DP_AbstractFactory.Factories;
using DP_AbstractFactory.Landvehicles;

namespace DP_AbstractFactory.App
{
    internal class Application
    {
        private IAirCraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
