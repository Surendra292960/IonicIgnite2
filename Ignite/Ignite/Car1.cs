using Apache.Ignite.Core;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Event;
using Apache.Ignite.Core.Cache.Query.Continuous;
using System;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Cache.Query;
using Apache.Ignite.Core.Binary;

namespace IgniteDemo
{
    class Car1
    {
        [QuerySqlField] public string Model { get; set; }
        [QuerySqlField] public int Power { get; set; }


        static void Main(string[] args)
        {

            try
            {
                var ignite = Ignition.Start();

                var queryEntity = new QueryEntity(typeof(int), typeof(Car1));
                var cacheConfig = new CacheConfiguration("cars1", queryEntity);
                ICache<int, Car1> cache = ignite.GetOrCreateCache<int, Car1>(cacheConfig);


                var insertQuery = new SqlFieldsQuery("INSERT INTO Car1 (_key, Model, Power) VALUES " +
                                                "(16, 'Ariel Atom', 350), " +
                                                "(21, 'Reliant Robin', 39)");
                cache.QueryFields(insertQuery).GetAll();


                var selQuery = new SqlQuery(typeof(Car1), "SELECT * FROM Car1 ORDER BY Power");
                foreach (ICacheEntry<int, Car1> entry in cache.Query(selQuery))
                    Console.WriteLine(entry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
