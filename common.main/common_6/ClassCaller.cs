using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_6
{
    /// <summary>
    /// 当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。
    /// 虚方法是使用关键字 virtual 声明的。
    /// 虚方法可以在不同的继承类中有不同的实现。
    /// 对虚方法的调用是在运行时发生的。
    /// 动态多态性是通过 抽象类 和 虚方法 实现的。
    /// </summary>
    class ClassCaller
    {
        public void CallArea(Shap sh)
        {
            int a;
            a = sh.GetArea();
            Console.WriteLine("面积：{0}\n", a);
        }
    }
}
