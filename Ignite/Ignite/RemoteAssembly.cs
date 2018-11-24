using Apache.Ignite.Core;
using Apache.Ignite.Core.Compute;
using Apache.Ignite.Core.Deployment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class RemoteAssembly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var cfg = new IgniteConfiguration
            {
                PeerAssemblyLoadingMode = PeerAssemblyLoadingMode.CurrentAppDomain
            };

            using (var ignite = Ignition.Start(cfg))
            {
                ignite.GetCompute().Broadcast(new HelloAction());
            }
            Console.ReadLine();
        }

        class HelloAction : IComputeAction
        {
            public void Invoke()
            {
                Console.WriteLine("Hello, World2!");
            }
        }

    }
}
