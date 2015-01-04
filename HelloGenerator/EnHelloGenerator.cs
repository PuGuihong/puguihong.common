using System;

namespace HelloGenerator
{
    public class EnHelloGenerator : common.ICommon.IHelloGenerator
    {

        public string GetHelloString(string name)
        {
            return String.Format("my name is :{0} ", name);
        }
    }
}