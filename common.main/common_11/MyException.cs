using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_11
{
    /// <summary>
    /// C# 中的异常类主要是直接或间接地派生于 System.Exception 类。System.ApplicationException 和 System.SystemException 类是派生于 System.Exception 类的异常类。
    /// System.ApplicationException 类支持由应用程序生成的异常。所以程序员定义的异常都应派生自该类。
    /// System.SystemException 类是所有预定义的系统异常的基类。
    /// 
    /// System.IO.IOException   处理 I/O 错误。
    /// System.IndexOutOfRangeException 处理当方法指向超出范围的数组索引时生成的错误。
    /// System.ArrayTypeMismatchException   处理当数组类型不匹配时生成的错误。
    /// System.NullReferenceException   处理当依从一个空对象时生成的错误。
    /// System.DivideByZeroException    处理当除以零时生成的错误。
    /// System.InvalidCastException 处理在类型转换期间生成的错误。
    /// System.OutOfMemoryException 处理空闲内存不足生成的错误。
    /// System.StackOverflowException   处理栈溢出生成的错误。
    /// </summary>
    public class MyException
    {
        double result ;
        public MyException()
        {
            result = 0.0;
        }

        public void Divisition(double num1,double num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("错误： {0}", ex);
            }
            finally 
            {

                Console.WriteLine("运算结果是: {0}", result);
            }
        }
        /// <summary>
        /// 引用自定义异常
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public void Divisition(int num1, int num2)
        {
            OwnExc ownexc = new OwnExc();
            try
            {
                ownexc.ShowTemp();
            }
            catch (OwnException ex)
            {
                Console.WriteLine("错误： {0}", ex.Message);
            }
            finally
            {

                Console.WriteLine("运算结果是: {0}", result);
            }
        }
    }
}
