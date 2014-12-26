using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_6
{
    class Rectangle:Shap
    {
        public Rectangle(int w = 0, int h = 0)
            : base(w, h)
        {

        }
        public override int GetArea()
        {
            Console.WriteLine("Rectangle 类的面积:");
            return width * height;
        }
    }
}
