using System;
using common.ICommon;

namespace SayHello
{
    public class SayHello : common.ICommon.ISayHello
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
                Console.WriteLine(helloGen.GetHelloString(name));
            }
            else
            {
                Console.WriteLine("Client.hello is not initialized");
            }
        }
    }
}
