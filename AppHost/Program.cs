using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context.Support;
using Spring.Context;

namespace AppHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextRegistry.GetContext();
            Console.WriteLine("服务已经启动");

            Console.ReadLine();
        }
    }
}
