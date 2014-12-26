using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_3
{
    class Rectangle:Shap,IPaintCost
    {
        public int GetArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }
}
