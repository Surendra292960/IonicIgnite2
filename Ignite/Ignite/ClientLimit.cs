using Apache.Ignite.Core;
using Apache.Ignite.Core.Communication.Tcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignite
{
    class ClientLimit
    {
        static void Main(string[] args)
        {
            var cfg = new IgniteConfiguration
            {
                CommunicationSpi = new TcpCommunicationSpi
                {
                    SlowClientQueueLimit = 1000
                }
            };
            Console.WriteLine("HEllowofwejknvihrev rfbeuvirbjmvurbj v ");
            Console.ReadLine();

        }
    }
}
