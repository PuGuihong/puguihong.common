using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_7
{
    /// <summary>
    /// 自定义的类 Box 实现了加法运算符（+）。
    /// 它把两个 Box 对象的属性相加，并返回相加后的 Box 对象。
    /// </summary>
    class Box
    {
        /// <summary>
        /// 长，宽，高
        /// </summary>
        private double length, height, breadth;

        public double GetVolume()
        {
            return height * length * breadth;
        }
        public void SetLength(double l)
        {
            length = l;
        }
        public void SetBreadth(double b)
        {
            breadth = b;
        }
        public void SetWidth(double h)
        {
            height = h;
        }
        /// <summary>
        /// + 重载
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Box operator + (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
        public static bool operator ==(Box b, Box c)
        {
            bool statu = false;
            if (b.length == c.length && b.height == c.height && b.breadth == c.breadth)
            {
                statu = true;
            }
            return statu;
        }

        public static bool operator !=(Box b, Box c)
        {
            bool stau = false;
            if (b.breadth != c.height || b.length != c.length || b.breadth != c.breadth)
            {
                stau = true;
            }
            return stau;
        }
    }
}
