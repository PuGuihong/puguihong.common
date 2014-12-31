using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common.ICommon;

namespace common.SayHello
{
    public class SayHello:common.ICommon.ISayHello
    {
        private IHelloGenerator helloGen;
        public IHelloGenerator HelloGenerator
        {
            get
            {
                return helloGen;
            }
            set
            {
                helloGen = value;
            }
        }

        public void SayHelloTo(string name)
        {
            if (helloGen != null)
            {
                Console.WriteLine("{0} \n",helloGen.GetHelloString(name));
            }
            else
            {
                Console.WriteLine("Client.hello is not initialized");
            }
        }
    }
}
