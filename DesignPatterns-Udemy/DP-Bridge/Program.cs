using DP_Bridge.Platforms;
using DP_Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge
{
    internal class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);
            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);
            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Result();
            live.Record();
        }

        static void Main(string[] args)
        {
            StartLive(new YouTube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartLiveAdvanced(new DLive());
            Console.ReadLine();
        }
    }
}
