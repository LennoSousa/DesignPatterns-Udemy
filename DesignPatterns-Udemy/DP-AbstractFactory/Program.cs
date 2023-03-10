using DP_AbstractFactory.App;
using DP_AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    internal class Program
    {

        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Lime";

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            } 
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
