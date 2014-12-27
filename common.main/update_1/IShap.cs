using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.update_1
{
    /// <summary>
    /// <para>规定 IShap 接口</para>
    /// 需要返回MessageModel格式信息包。
    /// 需要实现GetPerim 计算周长的方法。
    /// 需要实现GetArea 计算面积的方法。
    /// </summary>
    interface IShap
    {
        /// <summary>
        /// 规定计算周长
        /// </summary>
        /// <returns></returns>
        BasicMessage GetPerim();
        /// <summary>
        /// 规定计算面积
        /// </summary>
        /// <returns></returns>
        BasicMessage GetArea();
    }
}
