namespace Server
{
    using System;
    using System.Threading;

    using Opc.UaFx.Server;
    using OPCUAServer;

    public class Program
    {
        public static void Main(string[] args)
        {                     
            {
                Console.WriteLine("OPC UA Server is ready...");
                new OpcServerApplication("opc.tcp://localhost:4840/", new Motor(), new Sensor(), new Robot()).Run();
            }
        }
    }
}