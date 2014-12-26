using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_11
{
    /// <summary>
    /// 自定义异常 派生于ApplicationException
    /// 
    /// </summary>
    public class OwnException:ApplicationException
    {
        public OwnException(string msg) : base(msg)
        { 
        
        }
    }
    public class OwnExc
    {
        int temprature = 0;
        public void ShowTemp()
        {
            if (temprature == 0)
            {
                throw (new OwnException("0 不可以被当做被除数"));
            }
            else
            {
                Console.WriteLine("过渡值是:{0}", temprature);
            }
        }
    }
}
