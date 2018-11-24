using Apache.Ignite.Core;
using Apache.Ignite.Core.Common;
using Apache.Ignite.Core.Compute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class Server
    {
        private static object ignite;

        static void Main(string[] args)
        {
            Ignition.ClientMode = true;

            //// Start Ignite in client mode.
            IIgnite ignite = Ignition.Start();

            //// Create cache on all the existing and future server nodes.
            //// Note that since the local node is a client, it will not 
            //// be caching any data.
            var cache = ignite.GetOrCreateCache<object, object>("cacheName");

            ICompute compute = ignite.GetCompute();

            // Execute computation on the server nodes (default behavior).
            //compute.Broadcast(new MyComputeAction());
        }
    }
}
