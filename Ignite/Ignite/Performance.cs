using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignite
{
    class Performance
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start();
            //var cfg = new IgniteConfiguration
            //{
            //    IncludedEventTypes =
            //{
            //  EventType.TaskStarted,
            //  EventType.TaskFinished,
            //  EventType.TaskFailed
            //}
            //};


            //var cfg = new IgniteConfiguration
            //{
            //    CacheConfiguration = new[]
            // {
            //    new CacheConfiguration
            //    {
            //            EvictionPolicy = new Apache.Ignite.Core.Cache.Eviction.LruEvictionPolicy { MaxSize = 1000000 }
            //        }
            //    }
            //};

            var cfg = new IgniteConfiguration
            {
                CacheConfiguration = new[]
             {
                  new CacheConfiguration
                  {
                        RebalanceBatchSize = 1024 * 1024,
                        RebalanceThrottle = TimeSpan.Zero  // disable throttling
                    }
            }
            };

            Console.WriteLine("Good Performance");
            Console.ReadLine();
        }
    }
}
