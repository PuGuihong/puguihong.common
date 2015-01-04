using System;

namespace HelloGenerator
{
    public class CnHelloGennerator : common.ICommon.IHelloGenerator
    {
        public string GetHelloString(string name)
        {
            return String.Format("我的名字是 : {0} ", name);
        }
    }
}
