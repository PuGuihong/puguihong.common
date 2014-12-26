using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_12
{
    /// <summary>
    /// <para>Windows 文件系统的操作</para>
    /// 
    /// 1.DirectoryInfo 类:
    /// <para>
    /// 派生自 FileSystemInfo 类。它提供了各种用于创建、移动、浏览目录和子目录的方法。
    /// 该类不能被继承。
    /// 常用属性如下：
    /// Attributes  获取当前文件或目录的属性。
    /// CreationTime    获取当前文件或目录的创建时间。
    /// Exists  获取一个表示目录是否存在的布尔值。
    /// Extension   获取表示文件存在的字符串。
    /// FullName    获取目录或文件的完整路径。
    /// LastAccessTime  获取当前文件或目录最后被访问的时间。
    /// Name    获取该 DirectoryInfo 实例的名称。
    /// </para>
    /// <para>
    /// 常用方法：
    /// public void Create()    创建一个目录。
    /// public DirectoryInfo CreateSubdirectory( string path )  在指定的路径上创建子目录。指定的路径可以是相对于 DirectoryInfo 类的实例的路径。
    /// public override void Delete()   如果为空的，则删除该 DirectoryInfo。
    /// public DirectoryInfo[] GetDirectories() 返回当前目录的子目录。
    /// public FileInfo[] GetFiles()    从当前目录返回文件列表。
    /// </para>
    /// 
    /// 2.FileInfo 类:
    /// <para>
    /// 它提供了用于创建、复制、删除、移动、打开文件的属性和方法，且有助于 FileStream 对象的创建。
    /// 该类不能被继承。
    /// Attributes  获取当前文件的属性。
    /// CreationTime    获取当前文件的创建时间。
    /// Directory   获取文件所属目录的一个实例。
    /// Exists  获取一个表示文件是否存在的布尔值。
    /// Extension   获取表示文件存在的字符串。
    /// FullName    获取文件的完整路径。
    /// LastAccessTime  获取当前文件最后被访问的时间。
    /// LastWriteTime   获取文件最后被写入的时间。
    /// Length  获取当前文件的大小，以字节为单位。
    /// Name    获取文件的名称。
    /// 常用方法：
    /// public StreamWriter AppendText()    创建一个 StreamWriter，追加文本到由 FileInfo 的实例表示的文件中。
    /// public FileStream Create()  创建一个文件。
    /// public override void Delete()   永久删除一个文件。
    /// public void MoveTo( string destFileName )   移动一个指定的文件到一个新的位置，提供选项来指定新的文件名。
    /// public FileStream Open( FileMode mode )     以指定的模式打开一个文件。
    /// public FileStream Open( FileMode mode, FileAccess access )  以指定的模式，使用 read、write 或 read/write 访问，来打开一个文件。
    /// public FileStream Open( FileMode mode, FileAccess access, FileShare share )     以指定的模式，使用 read、write 或 read/write 访问，以及指定的分享选项，来打开一个文件。
    /// public FileStream OpenRead()    创建一个只读的 FileStream。
    /// public FileStream OpenWrite()   创建一个只写的 FileStream。
    /// </para>
    /// </summary>
    class MyDirectoryHelper
    {
        public void GetDirectory()
        {
            //创建directoryinfo 对象
            DirectoryInfo dir = new DirectoryInfo(@"d:\");

            //获取目录和文件信息
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine("文件夹：{0} \n",dir.Name);
            foreach (FileInfo f in files)
            {
                Console.WriteLine("文件名：{0},文件大小:{1}", f.Name,f.Length);
            }
        }
    }
}
