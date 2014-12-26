using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_14
{
    /// <summary>
    /// <para>反射（Reflection）</para>
    /// 
    /// <para>
    /// 对象用于在运行时获取类型信息。
    /// 该类位于 System.Reflection 命名空间中，可访问一个正在运行的程序的元数据。
    /// </para>
    /// <para>
    /// 允许获取有关应用程序信息及向应用程序动态添加类型、值和对象的类。
    /// </para>
    /// <para>实际应用</para>
    /// 它允许在运行时查看属性（attribute）信息。
    /// 它允许审查集合中的各种类型，以及实例化这些类型。
    /// 它允许延迟绑定的方法和属性（property）。
    /// 它允许在运行时创建新类型，然后使用这些类型执行一些任务。
    /// </summary>
    [AttributeHelper("ReflectionHelper 类的描述信息")]
    class ReflectionHelper
    {
    }
}
