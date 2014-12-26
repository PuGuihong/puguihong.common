using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_12
{
    /// <summary>
    /// 根本上说，流是通过通信路径传递的字节序列。
    /// 有两个主要的流：输入流 和 输出流。
    /// 输入流用于从文件读取数据（读操作），输出流用于向文件写入数据（写操作）。
    /// 
    /// System.IO 命名空间中常用的非抽象类
    /// BinaryReader 从二进制流读取原始数据。
    /// BinaryWriter    以二进制格式写入原始数据。
    /// BufferedStream  字节流的临时存储。
    /// Directory   有助于操作目录结构。
    /// DirectoryInfo   用于对目录执行操作。 
    /// DriveInfo   提供驱动器的信息。
    /// File    有助于处理文件。
    /// FileInfo    用于对文件执行操作。
    /// FileStream  用于文件中任何位置的读写。
    /// MemoryStream    用于随机访问存储在内存中的数据流。
    /// Path    对路径信息执行操作。
    /// StreamReader    用于从字节流中读取字符。
    /// StreamWriter    用于向一个流中写入字符。
    /// StringReader    用于读取字符串缓冲区。
    /// StringWriter    用于写入字符串缓冲区。
    /// </summary>
    public class MyFileHelper
    {
        /// <summary>
        /// byte 字节流文件的读写
        /// </summary>
        public void ByteFileReader()
        {
            try
            {
                FileStream files = new FileStream("byte_sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    for (int i = 0; i <= 20; i++)
                    {   
                        files.WriteByte((byte)i);
                    }
                    files.Position = 0;
                    for (int i = 0; i <= files.Length; i++)
                    {
                        Console.WriteLine(files.ReadByte());
                    }
                    files.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
            
        }
        /// <summary>
        /// stream reader 文本文件的读写
        /// <para>
        /// StreamReader 类中一些常用的方法:
        /// public override void Close()    关闭 StreamReader 对象和基础流，并释放任何与读者相关的系统资源。
        /// public override int Peek()  返回下一个可用的字符，但不使用它。
        /// public override int Read()  从输入流中读取下一个字符，并把字符位置往前移一个字符。
        /// </para>
        /// </summary>
        public void TextFileReader()
        {
            try
            {
                string line;
                StreamReader sr = new StreamReader("stream_sample.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
        }
        /// <summary>
        /// SreamWriter 类
        /// 
        /// <para>
        /// 常用的方法：
        /// public override void Close()    关闭当前的 StreamWriter 对象和基础流。
        /// public override void Flush()    清理当前编写器的所有缓冲区，使得所有缓冲数据写入基础流。
        /// public virtual void Write(bool value)   把一个布尔值的文本表示形式写入到文本字符串或流。（继承自 TextWriter。）
        /// public override void Write( char value )    把一个字符写入到流。
        /// public virtual void Write( decimal value )  把一个十进制值的文本表示形式写入到文本字符串或流。
        /// public virtual void Write( double value )   把一个 8 字节浮点值的文本表示形式写入到文本字符串或流。
        /// public virtual void Write( int value )  把一个 4 字节有符号整数的文本表示形式写入到文本字符串或流。
        /// public override void Write( string value )  把一个字符串写入到流。
        /// public virtual void WriteLine() 把行结束符写入到文本字符串或流。
        /// </para>
        /// </summary>
        public void WriteStream()
        {
            try { 
                    string[,] str = { { "pu", "26岁" }, { "zhang", "23岁" }, { "liu", "22岁" }, { "yang", "21岁" } };
                    //将值 以流方式写入文件
                    StreamWriter sw = new StreamWriter("name_sample.txt");
                    foreach (string s in str)
                    {
                        sw.WriteLine(s);
                    }
                    sw.Close();
                    //从文件中读取并打印
                    string line;
                    StreamReader sr = new StreamReader("name_sample.txt");
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    sr.Close();
                }
            catch (IOException ex)
            {
                Console.WriteLine("文件读写失败，错误提示：{0}", ex);
            }
        }
    }
}
