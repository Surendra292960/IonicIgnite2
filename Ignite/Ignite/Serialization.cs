using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using System;


namespace IgniteDemo
{
    public class Serialization
    {
        static void Main(string[] args)
        {
            IIgnite ignite = Ignition.Start();

            IBinaryObjectBuilder builder = ignite.GetBinary().GetBuilder("Book");

            IBinaryObject book = builder
              .SetField("ISBN", "xyz")
              .SetField("Title", "War and Peace")
              .Build();
            Console.WriteLine("War and Peace");
            Console.ReadLine();
        }
    }
}
