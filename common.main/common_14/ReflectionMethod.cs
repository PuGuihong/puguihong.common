using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using common.main.common_13;
using System.Reflection;

namespace common.main.common_14
{
    class ReflectionMethod
    {
        /// <summary>
        ///使用反射（Reflection）来读取 自定义属性 类中的元数据。
        ///读取MyAttribute类中自定义属性的元数据。
        /// </summary>
        public void GetCellAttribute()
        {
            common_13.MyAttribute myattribute = new common_13.MyAttribute(4.32, 2.21);
            myattribute.Display();
            Type type = typeof(common_13.MyAttribute);
            //遍历MyAttribute中属性的元数据
            Console.WriteLine("MyAttribute 元数据的属性 \n");
            foreach (object obj in type.GetCustomAttributes(false))
            {
                common_13.DeBugInfo dbi = (common_13.DeBugInfo)obj;
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }
        }
        /// <summary>
        /// 遍历方法的属性
        /// </summary>
        public void GetMethodAttribute()
        {
            Type type = typeof(common_13.MyAttribute);
            Console.WriteLine("MyAttribute 方法的属性 \n");
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute obj in m.GetCustomAttributes(true))
                {
                    common_13.DeBugInfo dbi = (common_13.DeBugInfo)obj;
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}",
                              dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}",
                              dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }
        }
    }
}
