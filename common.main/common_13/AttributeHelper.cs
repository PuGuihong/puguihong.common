using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_13
{
    /// <summary>
    /// <para>C# 特性（Attribute）</para>
    /// <para>
    /// 是用于在运行时传递程序中各种元素（比如类、方法、结构、枚举、组件等）的行为信息的声明性标签。
    /// 可以通过使用特性向程序添加声明性信息。
    /// 一个声明性标签是通过放置在它所应用的元素前面的方括号（[ ]）来描述的。
    /// 添加元数据，如编译器指令和注释、描述、方法、类等其他信息。
    /// .Net 框架提供了两种类型的特性：预定义特性和自定义特性。
    /// </para>
    /// 
    /// <para>
    /// 
    /// </para>
    /// 
    /// 
    /// </summary>
    class AttributeHelper
    {
        public void Func1()
        {
            ShowMessage("第一次 调用");
            Func2();
        }

        private void Func2()
        {
            ShowMessage("第二次 调用");
        }
        /// <summary>
        /// 当调试代码时显示变量的值
        /// </summary>
        /// <param name="msg"></param>
        [Conditional("DEBUG")]
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
