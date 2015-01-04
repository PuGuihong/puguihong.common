using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContract;
namespace WcfService
{
    public class ImplementService :IContract.IWcfContract
    {
        public string GetData(int value)
        {
            return "你输入的是 :" + value;
        }
    }
}
