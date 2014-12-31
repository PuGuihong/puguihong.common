using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common.ICommon;

namespace HelloGenerator
{
    public class EnHelloGenerator:common.ICommon.IHelloGenerator
    {
        public string GetHelloString(string name)
        {
            return String.Format("my name is :{0} ", name);
        }
    }
}
