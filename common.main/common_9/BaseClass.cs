#define PI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_9
{
    class BaseClass
    {
           public void CallDefine()
           {
#if(PI)
               Console.WriteLine("获取 PI ");
#else
               Console.WriteLine("未获取 PI");
#endif
           }
    }
}
