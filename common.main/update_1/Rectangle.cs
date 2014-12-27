using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.update_1
{
    public class Rectangle:IShap
    {
        private double length, wide;
        private StringBuilder formula= new StringBuilder();
        private StringBuilder description = new StringBuilder();
        public BasicMessage bas_message = new BasicMessage();
        public Rectangle(double l,double w)
        {
            length = l;
            wide = w;
        }
        public BasicMessage GetPerim()
        {
            //message = new MessageModel();
            formula = formula.Append("计算公式：（" + length);
            formula.Append(" + " + wide);
            formula.Append(" ）*2");
            description = description.Append("需要两根长" + length + "的料;");
            description.Append("需要两根长" + wide + "的料;");
            bas_message.HandleName = "GetPerim";
            bas_message.Result = (length + wide) * 2;
            bas_message.Formula = formula.ToString();
            bas_message.Description = description.ToString();
            return bas_message;
        }


        public BasicMessage GetArea()
        {
            //message = new MessageModel();
            formula = formula.Append("计算公式：（" + length);
            formula.Append(" * " + wide);
            formula.Append(" ）");

            bas_message.HandleName = "GetArea";
            bas_message.Result = (length + wide) * 2;
            description = description.Append("需要 面积为 " + bas_message.Result + " 的料;");
            bas_message.Formula = formula.ToString();
            bas_message.Description = description.ToString();
            return bas_message;            
        }
    }
}
