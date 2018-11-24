using Apache.Ignite.Core;
using Apache.Ignite.Core.Communication.Tcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class ClusterNetworking
    {
        static void Main(string[] args)
        {
            var cfg = new IgniteConfiguration
            {
                CommunicationSpi = new TcpCommunicationSpi
                {
                    LocalPort = 4321   // Override local port.
                }
            };
            Console.WriteLine("Hello Cluster Networking");
            Console.ReadLine();
        }
    }
}
