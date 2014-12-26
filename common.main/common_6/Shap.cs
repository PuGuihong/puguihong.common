using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_6
{
    class Shap
    {
        protected int width, height;
        public Shap(int w=0,int h=0)
        {
            width = w;
            height = h; 
        }
        public virtual int GetArea()
        {
            Console.WriteLine("父类的面积: ");
            return 0;
        }
    }
}
