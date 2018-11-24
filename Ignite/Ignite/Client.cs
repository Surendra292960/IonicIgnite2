using Apache.Ignite.Core;
using Apache.Ignite.Core.Cluster;
using Apache.Ignite.Core.Compute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class Client
    {
        private static object ignite;

        static void Main(string[] args)
        {

            Ignition.ClientMode = true;

            //// Start Ignite in client mode.

            IIgnite ignite = Ignition.Start();
            IClusterGroup clientGroup = ignite.GetCluster().ForClientNodes(null);

            ICompute clientCompute = clientGroup.GetCompute();

            // Execute computation on the client nodes.
            //clientCompute.Broadcast(new MyComputeAction());
        }
    }
}
