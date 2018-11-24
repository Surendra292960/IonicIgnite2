using Apache.Ignite.Core;
using Apache.Ignite.Core.Cluster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class Cluster1
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start();
            ICluster cluster = ignite.GetCluster();

            //One===>>
            var cfg = new IgniteConfiguration
            {
                UserAttributes = new Dictionary<string, object> { { "ROLE", "worker" } }
            };

            //Two===>>
            IClusterGroup workers = ignite.GetCluster().ForAttribute("ROLE", "worker");
            ICollection<IClusterNode> nodes = workers.GetNodes();

            IClusterNode localNode = cluster.GetLocalNode();


            // Three===>>    Node metrics.
            IClusterMetrics metrics = localNode.GetMetrics();
            Console.WriteLine("Three  Started.");

            // Get some metric values.
            double cpuLoad = metrics.CurrentCpuLoad;
            long usedHeap = metrics.HeapMemoryUsed;
            int numberOfCores = metrics.TotalCpus;
            int activeJobs = metrics.CurrentActiveJobs;


            IClusterNode localNode1 = ignite.GetCluster().GetLocalNode();

            Console.WriteLine("Hello From Server.\n"+"Cluster Started.");
            Console.ReadLine();
        }
    }
}
