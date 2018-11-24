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
    class Compute
    {
        private static IComputeAction job;

        static void Main(string[] args)
        {

            Ignition.ClientMode = true;

            //// Start Ignite in client mode.

            IIgnite ignite = Ignition.Start();
            var compute = ignite.GetCompute();

            while (true)
            {
                try
                {
                    compute.Run(job);
                }
                catch (ClientDisconnectedException e)
                {
                    e.ClientReconnectTask.Wait(); // Wait for reconnection.

                    // Can proceed and use the same ICompute instance.
                }
                Console.WriteLine("Hello sdfwhvcrw  ufvbc nkwe  lfrchnwbfrwfrw");
                Console.ReadLine();
            }

        }
    }
}
