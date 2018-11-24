using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgniteDemo
{
    class DurableMemory
    {
        public static bool DataRegionName { get; private set; }
        public static bool Name { get; private set; }

        static void Main(string[] args)
        {

            IIgnite ignite = Ignition.Start();
            var cfg = new IgniteConfiguration
            {
                DataStorageConfiguration = new DataStorageConfiguration
                {
                    DefaultDataRegionConfiguration = new DataRegionConfiguration
                    {
                        Name = "defaultRegion",
                        InitialSize = 128 * 1024 * 1024,  // 128 MB,
                        MaxSize = 4L * 1024 * 1024 * 1025  // 4 GB
                    },
                    DataRegionConfigurations = new[]
                    
                    {
                        new DataRegionConfiguration
                    {

                       Name = "customRegion",
                       InitialSize = 32 * 1024 * 1024,  // 32 MB,
                       MaxSize = 512 * 1024 * 1025  // 512 MB
                    }
                  }
                },
                    CacheConfiguration = new[]
                {
                    new CacheConfiguration
                 {
                    Name = "cache1"  // Use default region
                },
                    new CacheConfiguration
                {
                    Name = "cache2",
                    DataRegionName = "customRegion"
                }
             }
            };
            Console.WriteLine("Hello from Durable Memory");
            Console.WriteLine(DataRegionName);
            Console.WriteLine(Name);
            Console.ReadLine();
        }
    }
}
