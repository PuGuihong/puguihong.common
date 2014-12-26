using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace common.main.common_15
{
    /// <summary>
    /// <para>哈希表（Hashtable）</para>
    /// 一系列基于键的哈希代码组织起来的键/值对。
    /// 它使用键来访问集合中的元素。
    /// 使用键访问元素时，则使用哈希表，而且您可以识别一个有用的键值。
    /// 哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。
    /// 
    /// <para>Hashtable 类的方法和属性</para>
    /// Count	获取 Hashtable 中包含的键值对个数。
    /// IsFixedSize	获取一个值，表示 Hashtable 是否具有固定大小。
    /// IsReadOnly	获取一个值，表示 Hashtable 是否只读。
    /// Item	获取或设置与指定的键相关的值。
    /// Keys	获取一个 ICollection，包含 Hashtable 中的键。
    /// Values	获取一个 ICollection，包含 Hashtable 中的值。
    /// 
    /// public virtual void Add( object key, object value );    向 Hashtable 添加一个带有指定的键和值的元素。
    /// public virtual void Clear();    从 Hashtable 中移除所有的元素。
    /// public virtual bool ContainsKey( object key );  判断Hashtable 是否包含指定的键。
    /// public virtual bool ContainsValue( object value );  判断 Hashtable 是否包含指定的值。
    /// public virtual void Remove( object key );   从 Hashtable 中移除带有指定的键的元素。
    /// </summary>
    class MyHashTable
    {
        private Hashtable ht = new Hashtable() { { "001", "px" }, { "002", "zz" }, { "003", "dax" },{"004", "xy"}};

        /// <summary>
        /// 判断哈希表中是否包含指定的值
        /// </summary>
        /// <param name="val"></param>
        public void ContainsValues(string val)
        {
            if (ht.ContainsValue(val))
            {
                Console.WriteLine("哈希表中已存在：{0}",val);
            }
            else
            {
                Console.WriteLine("哈希表中不存在要查找的元素！");
            }
        }
        /// <summary>
        /// 显示哈希表中的值
        /// </summary>
        public void ShowHashTable()
        {
            ICollection key = ht.Keys;
            Console.WriteLine("哈希表中键值打印：\n");
            foreach (string k in key)
            {
                Console.WriteLine(k + " : " + ht[k]);
            }
        }


    }
}
