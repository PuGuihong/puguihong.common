using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_14
{
    [AttributeUsage(AttributeTargets.All)]
    class AttributeHelper:System.Attribute
    {
        public readonly string url;
        private string topic;

        public AttributeHelper(string u)
        {
            this.url = u;
        }

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
    }
}
