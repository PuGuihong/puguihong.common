using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_17
{
    /// <summary>
    /// Enum 枚举是值数据类型。
    /// 枚举包含自己的值，且不能继承或传递继承。
    /// </summary>
    class MyEnum
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        public MyEnum()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
        }
    }
}
