using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
using IContract;

namespace AppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            ////调用 web 宿主
            //IWcfContract webProxy = (IWcfContract)ctx.GetObject("WebProxy");
            //Console.WriteLine(webProxy.GetData(1));

            //调用App宿主
            IWcfContract appProxy = (IWcfContract)ctx.GetObject("AppProxy");

            Console.ReadLine();
        }
    }
}
