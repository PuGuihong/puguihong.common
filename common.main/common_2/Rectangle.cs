using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_2
{
    class Rectangle
    {
        public double width;
        public double height;
        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }
        public double GetArea()
        {
            return width * height;
        }
        public void Display()
        {
            Console.WriteLine("长方形的长是{0}", width);
            Console.WriteLine("长方形的高是{0}", height);
            Console.WriteLine("长方形的面积是{0}", GetArea());
        }
    }
}
