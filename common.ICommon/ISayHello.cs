using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.ICommon
{
    public interface ISayHello
    {
        IHelloGenerator HelloGenerator { get; set; }
        void SayHelloTo(string name);
    }
}
