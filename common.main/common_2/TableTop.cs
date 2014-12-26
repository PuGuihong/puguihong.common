using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_2
{
    class TableTop:Rectangle
    {
        public double cost;
        public TableTop(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            cost = GetArea() * 70;
            return cost;
        }
        public void DisPlay()
        {
            base.Display();
            Console.WriteLine("成本:{0} \n", GetCost());
        }
    }
}
