using System;
using common.ICommon;
using Spring.Context;
using Spring.Context.Support;

namespace common.spring.mainapp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IApplicationContext ctx = ContextRegistry.GetContext();
                ICommon.ISayHello sayHello = ctx.GetObject("mySayHello") as ICommon.ISayHello;
                sayHello.SayHelloTo("zhenyulu");

                sayHello.HelloGenerator = ctx.GetObject("myCnHelloGenerator") as IHelloGenerator;
                sayHello.SayHelloTo("zhenyulu");

                Console.WriteLine("ttst ---------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误：{0} \n", ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
