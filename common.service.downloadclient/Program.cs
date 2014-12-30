using System;
using System.ServiceModel;
using System.IO;
using System.Threading;

namespace common.service.downloadclient
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {

                Thread.Sleep(1000);
                Console.WriteLine("第 {0} 次下载 \n", i + 1);
                Test();

            }
            Console.ReadLine();
            
        }

        public static void Back()
        {
            //string strAddress = "net.tcp://localhost:54321/Message/Streamed";
            //ChannelFactory<downloadclient.ServiceFileDown.IStreamed> factory = new ChannelFactory<downloadclient.ServiceFileDown.IStreamed>("NetTcpBinding_IStreamed", new EndpointAddress(strAddress));
            //downloadclient.ServiceFileDown.IStreamed service = factory.CreateChannel();
            //downloadclient.ServiceFileDown.DownloadFileWrapper filewrap = new DownloadFileWrapper() { FilePath = @"D:\1.jpg" };
            //downloadclient.ServiceFileDown.DownloadResult result = null;
            //string filepath = @"E:\download_" + System.DateTime.Now.ToString("yy_MM_dd_hh_mm_ss") + ".jpg";
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch(); //定义观察者

            //watch.Start();
            //result = service.DownloadFile(filewrap);
            //Stream sourcestream = result.FileData;
            //watch.Stop();
            //try
            //{
            //    System.IO.FileStream targetstream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None);
            //    var buffer = new byte[4096];
            //    var count = 0;
            //    while ((count = sourcestream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        targetstream.Write(buffer, 0, count);
            //    }
            //    Console.WriteLine("下载成功,下载目录为：{0} , 文件大小： {1}", filepath, targetstream.Length.ToString());
            //    sourcestream.Close();
            //    targetstream.Close();
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("下载失败！{0}\n", ex);
            //    throw;
            //}
        }
        public static bool Test()
        {
            string strAddress = "net.tcp://localhost:54321/Message/Streamed";
            ChannelFactory<downloadclient.ServiceFileDown.IStreamed> factory = new ChannelFactory<downloadclient.ServiceFileDown.IStreamed>("NetTcpBinding_IStreamed", new EndpointAddress(strAddress));
            downloadclient.ServiceFileDown.IStreamed service = factory.CreateChannel();
            string filepath = @"E:\download_" + System.DateTime.Now.ToString("yy_MM_dd_hh_mm_ss") + ".jpg";
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
                sourcestream.Close();
                targetstream.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("下载失败！{0}\n", ex);
                return false;
            }
        }
    }
}
