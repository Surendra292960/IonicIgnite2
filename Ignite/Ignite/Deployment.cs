using Apache.Ignite.Core;
using Apache.Ignite.Core.Client;
using Apache.Ignite.Core.Client.Cache;
using Apache.Ignite.Core.Configuration;
using Apache.Ignite.Core.Impl.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class Deployment
    {


        static void Main(string[] args)
        {

            IIgnite ignite = Ignition.Start();
            //var cfg = new IgniteConfiguration
            //{
            //    ClientConnectorConfiguration = new ClientConnectorConfiguration
            //    {
            //        Host = "myHost",
            //        MaxOpenCursorsPerConnection = 64,
            //        Port = 10900,
            //        PortRange = 50
            //    }
            //};

            //var cfg = new IgniteClientConfiguration
            //{
            //    Host = "127.0.0.1"
            //};

            //using (IIgniteClient client = Ignition.StartClient(cfg))
            //{
            //    ICacheClient<int, string> cache = client.GetCache<int, string>("cache");
            //    cache.Put(1, "Hello, World!");
            //}


            var cfg = new IgniteClientConfiguration
            {
                Host = "192.168.1.55",
                Port = 8080,
                UserName = "ignite",
                Password = "kg1mmcoXZU"
            };

            using (IIgniteClient client = Ignition.StartClient(cfg))
            {
                ICacheClient<int, string> cache = client.GetCache<int, string>("cache");
                cache.Put(1, "Hello, World!");
            }
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
