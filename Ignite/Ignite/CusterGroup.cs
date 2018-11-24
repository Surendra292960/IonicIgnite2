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
    class CusterGroup
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start();
            //ICluster cluster = ignite.GetCluster();

            //// All nodes with attribute "ROLE" equal to "worker".
            //IClusterGroup attrGroup = cluster.ForAttribute("ROLE", "worker");

            ICluster cluster = ignite.GetCluster();

            // Pick a remote node.
            IClusterNode remoteNode = cluster.ForRemotes().GetNode();

            // All nodes on the same physical host as the remote node.
            IClusterGroup sameHost = cluster.ForHost(remoteNode);

            
            // Dynamic cluster group representing the oldest cluster node.
            // Will automatically shift to the next oldest, if the oldest
            // node crashes.
            IClusterGroup oldestNode = cluster.ForOldest();


            // Cluster group with remote nodes, i.e. other than this node.
            IClusterGroup remoteGroup = ignite.GetCluster().ForRemotes();

            // Cluster group metrics.
            IClusterMetrics metrics = remoteGroup.GetMetrics();

            // Get some metric values.
            double cpuLoad = metrics.CurrentCpuLoad;
            long usedHeap = metrics.HeapMemoryUsed;
            int numberOfCores = metrics.TotalCpus;
            int activeJobs = metrics.CurrentActiveJobs;


            IClusterGroup youngestNode = cluster.ForYoungest();

            Console.WriteLine("Hello CusterGroup");
            Console.ReadLine();
        }
    }
}
