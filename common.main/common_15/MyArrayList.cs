using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_15
{
    /// <summary>
    /// <para>
    /// 动态数组（ArrayList）
    /// </para>
    /// 可被单独索引的对象的有序集合。
    /// 它基本上可以替代一个数组。
    /// 但是，与数组不同的是，您可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。
    /// 它也允许在列表中进行动态内存分配、增加、搜索、排序各项。
    /// 
    /// <para>方法和属性</para>
    /// Capacity    获取或设置 ArrayList 可以包含的元素个数。
    /// Count	获取 ArrayList 中实际包含的元素个数。
    /// IsFixedSize	获取一个值，表示 ArrayList 是否具有固定大小。
    /// IsReadOnly	获取一个值，表示 ArrayList 是否只读。
    /// Item	获取或设置指定索引处的元素。
    /// <para>常用方法</para>
    /// public virtual int Add( object value );     在 ArrayList 的末尾添加一个对象。
    /// public virtual void AddRange( ICollection c );  在 ArrayList 的末尾添加 ICollection 的元素。
    /// public virtual void Clear();    从 ArrayList 中移除所有的元素。
    /// public virtual bool Contains( object item );    判断某个元素是否在 ArrayList 中。
    /// public virtual ArrayList GetRange( int index, int count );  返回一个 ArrayList，表示源 ArrayList 中元素的子集。
    /// public virtual int IndexOf(object); 返回某个值在 ArrayList 中第一次出现的索引，索引从零开始。
    /// public virtual void Insert( int index, object value );  在 ArrayList 的指定索引处，插入一个元素。
    /// public virtual void InsertRange( int index, ICollection c );    在 ArrayList 的指定索引处，插入某个集合的元素。
    /// public virtual void Remove( object obj );   从 ArrayList 中移除第一次出现的指定对象。
    /// public virtual void RemoveAt( int index );  移除 ArrayList 的指定索引处的元素。
    /// public virtual void RemoveRange( int index, int count );    从 ArrayList 中移除某个范围的元素。
    /// public virtual void Reverse();  逆转 ArrayList 中元素的顺序。
    /// public virtual void SetRange( int index, ICollection c );   复制某个集合的元素到 ArrayList 中某个范围的元素上。
    /// public virtual void Sort(); 对 ArrayList 中的元素进行排序。
    /// public virtual void TrimToSize();   设置容量为 ArrayList 中元素的实际个数。
    /// </summary>
    class MyArrayList
    {
        private ArrayList arraylist;
        /// <summary>
        /// 添加元素
        /// </summary>
        public void Add()
        {
            arraylist = new ArrayList();
            arraylist.Add(32);
            arraylist.Add("12");
            arraylist.Add(true);
            arraylist.Add(12.11);
            ShowContent();
            Console.WriteLine("arraylist 的 Capacity 属性是，可以包含的元素个数：{0}", arraylist.Capacity);
        }
        /// <summary>
        /// 显示数组元素
        /// </summary>
        public void ShowContent()
        {
            Console.WriteLine("原始 arraylist 的值是：\n");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj + " ");
            }
        }
        /// <summary>
        /// 对动态数组进行排序
        /// 
        /// 动态数组的元素必须是相同的类型，否则无法进行比较。
        /// </summary>
        public void SortArray()
        {
            arraylist = new ArrayList() { "the","mention","baby","type","case"};
            arraylist.Sort();
            Console.WriteLine("排序后的 arraylist 的值是：\n");
            foreach (object obj in arraylist)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("arraylist 的 Capacity 属性是，可以包含的元素个数：{0}", arraylist.Capacity);
        }

    }
}
