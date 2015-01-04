using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace IContract
{
    [ServiceContract]
    public interface IWcfContract
    {
        [OperationContract]
        string GetData(int value);
    }
}
