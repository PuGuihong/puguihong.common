using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common.ICommon;

namespace HelloGenerator
{
    class CnHelloGennerator : common.ICommon.IHelloGenerator
    {
        public string GetHelloString(string name)
        {
            return String.Format("我的名字是 : {0} ", name);
        }
    }
}
