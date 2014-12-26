using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_15
{
    /// <summary>
    /// <para>点阵列（BitArray）</para>
    /// BitArray 类管理一个紧凑型的位值数组，它使用布尔值来表示，其中 true 表示位是开启的（1），false 表示位是关闭的（0）.
    /// 当需要存储位，但是事先不知道位数时，则使用点阵列。您可以使用整型索引从点阵列集合中访问各项，索引从零开始。
    /// <para>常用属性和方法</para>
    /// Count	获取 BitArray 中包含的元素个数。
    /// IsReadOnly	获取一个值，表示 BitArray 是否只读。
    /// Item	获取或设置 BitArray 中指定位置的位的值。
    /// Length	获取或设置 BitArray 中的元素个数。
    /// 
    /// public BitArray And( BitArray value ); 
    /// 对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位与操作。
    /// public bool Get( int index );   获取 BitArray 中指定位置的位的值。
    /// public BitArray Not();  把当前的 BitArray 中的位值反转，以便设置为 true 的元素变为 false，设置为 false 的元素变为 true。
    /// public BitArray Or( BitArray value );   对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位或操作。
    /// public void Set( int index, bool value );   把 BitArray 中指定位置的位设置为指定的值。
    /// public void SetAll( bool value );   把 BitArray 中的所有位设置为指定的值。
    /// public BitArray Xor( BitArray value );  对当前的 BitArray 中的元素和指定的 BitArray 中的相对应的元素执行按位异或操作。
    /// </summary>
    class MyBitArray
    {
        //创建两个大小为8的点阵列
        BitArray bta1 = new BitArray(8);
        BitArray bta2 = new BitArray(8);
        byte[] a = { 60 };
        byte[] b = { 13 };
        public void ShowBitArray()
        {
            //将a,b的值存储到阵列中
            bta1 = new BitArray(a);
            bta2 = new BitArray(b);
            //bta1的内容
            Console.WriteLine("点阵列 bta1:60");
            for (int i = 0; i < bta1.Length; i++)
            {
                Console.Write("{0, -6} ", bta1[i]);
            }
            //bta2的内容
            Console.WriteLine("点阵列 bta2:13");
            for (int i = 0; i < bta2.Length; i++)
            {
                Console.Write("{0, -6} ", bta2[i]);
            }
            //bta3 and 的内容
            BitArray bta3 = new BitArray(8);
            bta3 = bta1.And(bta2);
            Console.WriteLine("点阵列 bta3:bta1 and bta2");
            for (int i = 0; i < bta3.Length; i++)
            {
                Console.Write("{0, -6} ", bta3[i]);
            }
            //bta4 Or 的内容
            BitArray bta4 = new BitArray(8);
            bta3 = bta1.Or(bta2);
            Console.WriteLine("点阵列 bta4:bta1 or bta2");
            for (int i = 0; i < bta4.Length; i++)
            {
                Console.Write("{0, -6} ", bta4[i]);
            }

        }
    }
}
