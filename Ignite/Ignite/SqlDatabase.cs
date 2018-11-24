using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Cache.Query;
using Apache.Ignite.Core.Common;
using System;

namespace IgniteDemo
{
    class SqlDatabase
    {
        static void Main(string[] args)
        {
            try
            {
                IIgnite ignite = Ignition.Start("default-config.xml");
                ICache<string, Seat> RowCache = ignite.GetOrCreateCache<string, Seat>(
                 new CacheConfiguration("Row", new QueryEntity(typeof(string), typeof(Seat))));


                var sql = new SqlQuery(typeof(Seat), "where SeatId > ?", 99990);
                IQueryCursor<ICacheEntry<string, Seat>> queryCursor = RowCache.Query(sql);
                foreach (ICacheEntry<string, Seat> entry in queryCursor)
                    Console.WriteLine(entry.Value.SeatId);
            }
            catch (IgniteException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

    }
}
