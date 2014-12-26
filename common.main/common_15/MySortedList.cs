using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_15
{
    /// <summary>
    /// <para>排序列表（SortedList）</para>
    /// 
    /// 代表了一系列按照键来排序的键/值对，这些键值对可以通过键和索引来访问。
    /// 排序列表是数组和哈希表的组合。
    /// 它包含一个可使用键或索引访问各项的列表。
    /// 如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）。
    /// 集合中的各项总是按键值排序。
    /// 
    /// <para>属性和方法</para>
    /// Capacity	获取或设置 SortedList 的容量。
    /// Count	获取 SortedList 中的元素个数。
    /// IsFixedSize	获取一个值，表示 SortedList 是否具有固定大小。
    /// IsReadOnly	获取一个值，表示 SortedList 是否只读。
    /// Item	获取或设置与 SortedList 中指定的键相关的值。
    /// Keys	获取 SortedList 中的键。
    /// Values	获取 SortedList 中的值。
    /// 
    /// <para>常用方法</para>
    /// public virtual void Add( object key, object value );    向 SortedList 添加一个带有指定的键和值的元素。
    /// public virtual void Clear();    从 SortedList 中移除所有的元素。
    /// public virtual void Clear();    从 SortedList 中移除所有的元素。
    /// public virtual bool ContainsValue( object value );  判断 SortedList 是否包含指定的值。
    /// public virtual object GetByIndex( int index );  获取 SortedList 的指定索引处的值。
    /// public virtual object GetKey( int index );  获取 SortedList 的指定索引处的键。
    /// public virtual IList GetKeyList();  获取 SortedList 中的键。
    /// public virtual IList GetValueList();    获取 SortedList 中的值。
    /// public virtual int IndexOfKey( object key );    返回 SortedList 中的指定键的索引，索引从零开始。
    /// public virtual int IndexOfValue( object value );    返回 SortedList 中的指定值第一次出现的索引，索引从零开始。
    /// public virtual void Remove( object key );   从 SortedList 中移除带有指定的键的元素。
    /// public virtual void RemoveAt( int index );  移除 SortedList 的指定索引处的元素。
    /// public virtual void TrimToSize();   设置容量为 SortedList 中元素的实际个数。
    /// </summary>
    class MySortedList
    {
        SortedList sl = new SortedList() { { "001", "pangxie" }, { "002", "xiaolongbao" }, { "003", "huiguorou" } ,{ "004", "daxia" },{ "006", "shuijiao" }};
        public void ShowSortedLst()
        {
            ICollection key = sl.Keys;
            Console.WriteLine("排序表中键值打印：\n");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
        }
    }
}
