using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SingleResponsabilityPrinciple.Utils
{
    internal class Notify
    {
        // Dessa forma, estamos respeitando o SIP, removendo as atividades
        // que não fazem parte do escopo da classe cliente, neste exemplo.
        public Notify(Client client)
        {
            Console.WriteLine("Notificando o cliente");
        }
    }
}
