using Apache.Ignite.Core;
using System;


namespace IgniteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ignition.Start();
               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Suree Connected Server"+ex.Message);
            }
            Console.ReadLine();
        }
    }
}
