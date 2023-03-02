namespace Server
{
    using System;
    using System.Threading;
    using Opc.UaFx;
    using Opc.UaFx.Server;
    using OPCUAServer;

    public class Program
    {
        static int nsvtout;
        // lifetime of server
        public static void Main(string[] args)
        {
            
            Console.WriteLine("OPC UA Server is ready...");
            var server = new OpcServerApplication("opc.tcp://localhost:4880/", new Motor(), new Sensor(), new Robot());
            server.Run();
            




        }
        
    }
}