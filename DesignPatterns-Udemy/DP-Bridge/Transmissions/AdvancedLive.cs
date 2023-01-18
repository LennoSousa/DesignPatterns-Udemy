using DP_Bridge.Platforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.Transmissions
{
    internal class AdvancedLive :  Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {

        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live!");
        }

        public void Record()
        {
            Console.WriteLine("Iniciando a gravação da Live!");
        }
    }
}
