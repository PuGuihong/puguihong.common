using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.update_1
{
    public struct MessageModel
    {
        public string ShapName;
        public List<BasicMessage> BMsgLst;
    }
    public struct BasicMessage
    {
        public string HandleName;
        public double Result;
        public string Formula;
        public string Description;
    }
}
