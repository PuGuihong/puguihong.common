using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_13
{
    /// <summary>
    /// 自定义Attribute类
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property ,AllowMultiple = true)]
    class DeBugInfo:System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        private string message;
        public DeBugInfo(int bg, string dev, string la)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = la;
        }

        public int BugNo
        {
            get { return bugNo; }
        }
        public string Developer
        {
            get { return developer; }
        }
        public string LastReview
        {
            get { return lastReview; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}
