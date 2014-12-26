using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_15
{
    /// <summary>
    /// <para>队列（Queue）</para>
    /// 代表了一个先进先出的对象集合。
    /// 当需要对各项进行先进先出的访问时，则使用队列。
    /// 当您在列表中添加一项，称为入队，当您从列表中移除一项时，称为出队。
    /// 
    /// <para>常用属性和方法</para>
    /// Count	获取 Queue 中包含的元素个数。
    /// public virtual void Clear();    从 Queue 中移除所有的元素。
    /// public virtual bool Contains( object obj );     判断某个元素是否在 Queue 中。
    /// public virtual object Dequeue();    移除并返回在 Queue 的开头的对象。
    /// public virtual void Enqueue( object obj );  向 Queue 的末尾添加一个对象。
    /// public virtual object[] ToArray();  复制 Queue 到一个新的数组中。
    /// public virtual void TrimToSize();   设置容量为 Queue 中元素的实际个数。
    /// </summary>
    class MyQueue
    {
        private Queue queue = new Queue();

        public void ShowQueue()
        {
            queue.Enqueue('M');
            queue.Enqueue('A');
            queue.Enqueue('N');
            queue.Enqueue('D');
            queue.Enqueue('M');
            Console.WriteLine("\n打印队列：\n ");
            foreach (char c in queue)
                Console.Write(c + " ");
        }
    }
}
