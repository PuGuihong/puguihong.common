using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_1
{
    class Rectangle:Shap
    {
        public int GetArea()
        {
            return width * height;
        }
        public int GetZhouC()
        {
            return (width + height) * 2;
        }
    }
}
