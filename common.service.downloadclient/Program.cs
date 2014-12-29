using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using common.service.downloadclient.ServiceFileDown;
using System.IO;

namespace common.service.downloadclient
{
    class Program
    {
        static void Main(string[] args)
        {
            string strAddress = "net.tcp://localhost:54321/Message/Streamed";
            ChannelFactory<downloadclient.ServiceFileDown.IStreamed> factory = new ChannelFactory<downloadclient.ServiceFileDown.IStreamed>("NetTcpBinding_IStreamed", new EndpointAddress(strAddress));
            downloadclient.ServiceFileDown.IStreamed service = factory.CreateChannel();

            string filepath = @"E:\2.jpg";
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch(); //定义观察者

            watch.Start();
            Stream sourcestream = service.DownloadFile();
            watch.Stop();
            try
            {
                System.IO.FileStream targetstream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None);
                var buffer = new byte[4096];
                var count = 0;
                while ((count = sourcestream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    targetstream.Write(buffer, 0, count);
                }
                Console.WriteLine("下载成功,下载目录为：{0} , 文件大小： {1}", filepath, targetstream.Length.ToString());
                Console.ReadLine();
                sourcestream.Close();
                targetstream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("下载失败！{0}\n",ex);
                throw;
            }
        }
    }
}
