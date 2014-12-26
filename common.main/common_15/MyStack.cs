using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_15
{
    /// <summary>
    /// <para>堆栈 Stack</para>
    /// 堆栈（Stack）代表了一个  后进先出    的对象集合。
    /// 当需要对各项进行后进先出的访问时，则使用堆栈。
    /// 当您在列表中添加一项，称为推入元素，当您从列表中移除一项时，称为弹出元素。
    /// <para>常用属性和方法</para>
    /// Count	获取 Stack 中包含的元素个数。
    /// 
    /// public virtual void Clear();    从 Stack 中移除所有的元素。
    /// public virtual bool Contains( object obj );     判断某个元素是否在 Stack 中。
    /// public virtual object Peek();   返回在 Stack 的顶部的对象，但不移除它。
    /// public virtual object Peek();   返回在 Stack 的顶部的对象，但不移除它。
    /// public virtual void Push( object obj ); 向 Stack 的顶部添加一个对象。
    /// public virtual object[] ToArray();  复制 Stack 到一个新的数组中。
    /// </summary>
    class MyStack
    {
        Stack st = new Stack() ;
        public void ShowStac()
        {
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');
            st.Push('E');
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            st.Push('V');
            st.Push('F');
            Console.WriteLine("在堆栈中下一个值是：{0}", st.Peek());
            Console.WriteLine("打印堆栈值:\n");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.WriteLine("移除栈顶元素 ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("打印堆栈: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }
    }
}
