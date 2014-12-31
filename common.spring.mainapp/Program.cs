using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Core;
using Spring.Data;
using Common.Logging;
using Spring.Context;
using common.ICommon;
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
                ISayHello sayHello = (ISayHello)ctx.GetObject("mySayHello");
                sayHello.SayHelloTo("zhenyulu");
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
