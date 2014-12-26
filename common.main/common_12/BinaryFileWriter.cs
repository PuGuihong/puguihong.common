using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace common.main.common_12
{
    /// <summary>
    /// BinaryWriter 类用于向文件写入二进制数据。
    /// 一个 BinaryWriter 对象通过向它的构造函数传递 FileStream 对象而被创建。
    /// 
    /// 常用方法:
    /// public override void Close()    关闭 BinaryWriter 对象和基础流。
    /// public virtual void Flush() 清理当前编写器的所有缓冲区，使得所有缓冲数据写入基础设备。
    /// public virtual long Seek( int offset, SeekOrigin origin )   设置当前流内的位置。
    /// public virtual void Write( bool value )     把一个单字节的布尔值写入到当前流中，0 表示 false，1 表示 true。
    /// public virtual void Write( byte value )     把一个无符号字节写入到当前流中，并把流的位置往前移一个字节。
    /// public virtual void Write( byte[] buffer )  把一个字节数组写入到基础流中。
    /// public virtual void Write( char ch )    把一个 Unicode 字符写入到当前流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。
    /// public virtual void Write( char[] chars )   把一个字符数组写入到当前流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。
    /// public virtual void Write( double value )   把一个 8 字节浮点值写入到当前流中，并把流位置往前移八个字节。
    /// public virtual void Write( int value )  把一个 4 字节有符号整数写入到当前流中，并把流位置往前移四个字节。
    /// public virtual void Write( string value ) 把一个以长度为前缀的字符串写入到 BinaryWriter 的当前编码的流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。
    /// </summary>
    class BinaryFileWriter
    {
        private BinaryWriter bw;
        private BinaryReader br;
        private int i = 25;
        private double d = 3.1415926;
        bool b = true;
        string s = "hello , my binary file .";

        //创建文件
        public void BinaryFileWR()
        {
            //写入文件
            try
            {
                bw = new BinaryWriter(new FileStream("binary_sample.txt", FileMode.Create));
            }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
            bw.Close();

            //读取文件
            try
            {
                br = new BinaryReader(new FileStream("binary_sample.txt", FileMode.Open));
            }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("读取的整型数据是：{0}", i);
                d = br.ReadDouble();
                Console.WriteLine("读取的浮点数据是：{0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("读取的布尔数据是：{0}", b);
                s = br.ReadString();
                Console.WriteLine("读取的字串数据是：{0}", s);
            }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
        }
    }
}
