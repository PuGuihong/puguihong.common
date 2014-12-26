using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_4
{
    /// <summary>
    /// 您可以在同一个范围内对相同的函数名有多个定义。
    /// 函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同。
    /// 不能重载只有返回类型不同的函数声明。
    /// </summary>
    class PrintData
    {
        public void Print(int i)
        {
            Console.WriteLine("print int: {0} \n",i);
        }
        public void Print(double f)
        {
            Console.WriteLine("print float: {0} \n", f);
        }
        public void Print(double f, int times)
        {
            for (int i = 0; i <= times; i++)
            {
                Console.WriteLine("第 {0} 次打印: {1} \n", i, f);
            }
        }
    }
}
