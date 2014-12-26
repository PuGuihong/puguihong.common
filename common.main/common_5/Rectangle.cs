using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_5
{
    /// <summary>
    ///  abstract 创建抽象类，用于提供接口的部分类的实现。
    ///  当一个派生类继承自该抽象类时，实现即完成。
    ///  抽象类包含抽象方法，抽象方法可被派生类实现。
    ///  派生类具有更专业的功能。
    ///  
    /// 规则:
    /// 不能创建一个抽象类的实例。
    /// 不能在一个抽象类外部声明一个抽象方法。
    /// 在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
    /// </summary>
    class Rectangle:Shap
    {
        private int width;
        private int height;

        public Rectangle(int w = 0, int h = 1)
        {
            width = w;
            height = h;
        }
        public override int GetArea()
        {
            int area =  width * height;
            Console.WriteLine("Rectangele的面积：{0} \n",area);
            return area;
        }
    }
}
