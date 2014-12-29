using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.update_1
{
    class Square:IShap
    {
        private double side;
        private StringBuilder formula = new StringBuilder();
        private StringBuilder description = new StringBuilder();
        public BasicMessage bas_message = new BasicMessage();
        //public MessageModel 
        public Square(double s)
        {
            side = s;
        }
        public BasicMessage GetPerim()
        {
            //message = new MessageModel();
            formula = formula.Append("计算公式：（" + side);
            formula.Append(" * 4 )");
            description = description.Append("需要 4 根长" + side + "的料;");

            bas_message.HandleName = "GetPerim";
            bas_message.Result = side * 4;
            bas_message.Formula = formula.ToString();
            bas_message.Description = description.ToString();
            return bas_message;
        }

        public BasicMessage GetArea()
        {
            //message = new MessageModel();
            formula = formula.Append("计算公式：（" + side);
            formula.Append(" * " + side + " ）");

            bas_message.HandleName = "GetArea";
            bas_message.Result = side * side;
            description = description.Append("需要 面积为 " + bas_message.Result + " 的料;");
            bas_message.Formula = formula.ToString();
            bas_message.Description = description.ToString();
            return bas_message;  
        }
    }
}
