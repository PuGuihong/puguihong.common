using System;
using System.ServiceModel;

namespace common.FileStreamUpDownService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Streamed)))
            {
                host.Opened += delegate
                {
                    Console.WriteLine("服务已经启动");
                };
                host.Open();
                foreach (var endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine(endpoint.Address.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
