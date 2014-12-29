using System;
using System.ServiceModel;

namespace common.service.client.mainapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strAddress = "net.tcp://localhost:54321/Message/Streamed";
            ChannelFactory<mainapp.ServiceFileUp.IStreamed> factory = new ChannelFactory<mainapp.ServiceFileUp.IStreamed>("NetTcpBinding_IStreamed", new EndpointAddress(strAddress));
            ServiceFileUp.IStreamed service = factory.CreateChannel();

            string filePath = @"D:\1.jpg";
            string newFilePath = @"D:\upload_" + System.DateTime.Now.ToString("yy_MM_dd_hh_mm_ss") + ".jpg";

            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch(); //定义观察者

            watch.Start();
            ServiceFileUp.UploadResult Result = service.UploadFile(GetStreamFromFile(filePath, newFilePath));
            watch.Stop();

            if (Result.ReturnResult)
            {
                Console.WriteLine("服务器接收的文件大小为：{0}\n", Result.FileSize);
                Console.WriteLine("上传成功,上传时间为：" + watch.ElapsedMilliseconds);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("上传失败");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// 流数据上传
        /// </summary>
        /// <param name="file">源文件地址</param>
        /// <param name="new_file_path">服务器文件地址</param>
        /// <returns></returns>
        public static ServiceFileUp.UploadFileWrapper GetStreamFromFile(string file, string new_file_path)
        {
            ServiceFileUp.UploadFileWrapper my_file = null;
            try
            {
                var sr = new System.IO.FileStream(file, 
                    System.IO.FileMode.Open);
                ServiceFileUp.UploadFileWrapper onfile = new ServiceFileUp.UploadFileWrapper()
                {
                    FilePath = new_file_path,
                    FileData = sr
                };
                my_file = onfile;
                Console.WriteLine("本地上传文件大小为：{0}\n", sr.Length.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return my_file;
        }
    }
}
