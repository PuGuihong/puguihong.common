using System;
using Spring.Context;
using common.ICommon;
using Spring.Core;
using Spring.Data;
using Common.Logging;
using System.Configuration;

namespace common.spring.mainapp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //IApplicationContext ctx = ConfigurationSettings.GetConfig("spring/context") as IApplicationContext;
                IApplicationContext ctx = System.Configuration.ConfigurationManager.GetSection("spring/context") as IApplicationContext;
                common.ICommon.ISayHello sayHello = (common.ICommon.ISayHello)ctx.GetObject("mySayHello");
                sayHello.SayHelloTo("zhenyulu");

                Spring.Context.IApplicationContext context = Spring.Context.Support.ContextRegistry.GetContext();
                common.ICommon.ISayHello sayH = context.GetObject() as ISayHello;

            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
