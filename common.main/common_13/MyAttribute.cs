using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_13
{
    /// <summary>
    /// 自定义特性的声明和引用
    /// 
    /// 声明自定义特性
    /// 构建自定义特性
    /// 在目标程序元素上应用自定义特性
    /// 通过反射访问特性
    /// 
    /// <para>自定义特性的应用</para>
    /// 最后一个步骤包含编写一个简单的程序来读取元数据以便查找各种符号。
    /// 元数据是用于描述其他数据的数据和信息。
    /// 该程序应使用反射来在运行时访问特性。
    /// 我们将在下一章详细讨论这点。
    /// </summary>
    [DeBugInfo(45,"pu","20141226",Message="测试方法 1")]
    [DeBugInfo(49, "pu", "20141229", Message = "测试方法 2")]
    class MyAttribute
    {
        private double width, length;
        public MyAttribute(double w,double l)
        {
            width = w;
            length = l;
        }
        [DeBugInfo(45, "pu", "20141226", Message = "测试方法 1")]
        public double GetArea()
        {
            return width * length;
        }
        [DeBugInfo(49, "pu", "20141229", Message = "测试方法 2")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
