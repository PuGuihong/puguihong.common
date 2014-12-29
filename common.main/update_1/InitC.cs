using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.update_1
{
    class InitC
    {
        public MessageModel message = new MessageModel();
        public List<BasicMessage> basc_message_lst;
        public ParamModel param = new ParamModel();
        private string shapename;
        public InitC(string sname)
        {
            param.l = 32.12;
            param.w = 12.21;
            shapename = sname;
            GetStart(); 
        }
        public MessageModel GetStart()
        {
            switch (shapename)
            {
                case "Rectangle":
                    basc_message_lst = new List<BasicMessage>();
                    Rectangle rectangle = new Rectangle(param.l,param.w);
                    basc_message_lst.Add(rectangle.GetPerim());
                    basc_message_lst.Add(rectangle.GetArea());
                    message.ShapName = shapename;
                    message.BMsgLst = basc_message_lst;
                    return message;
                case "Square":
                    basc_message_lst = new List<BasicMessage>();
                    Square square = new Square(param.l);
                    basc_message_lst.Add(square.GetPerim());
                    basc_message_lst.Add(square.GetArea());
                    message.ShapName = shapename;
                    message.BMsgLst = basc_message_lst;
                    return message;
                default:
                    return message;

            }
        }
    }
}
