using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace common.FileStreamUpDownService
{
    class Streamed : IStreamed
    {
        /// <summary>
        /// 文件上传服务
        /// </summary>
        /// <param name="fileWrapper">FileStreamUpDownService.UploadFileWrapper</param>
        /// <returns>FileStreamUpDownService.UploadResult</returns>
        public UploadResult UploadFile(UploadFileWrapper fileWrapper)
        {
            UploadResult result = new UploadResult();
            try
            {
                var sourceSream = fileWrapper.FileData;
                var targetSream = new FileStream(fileWrapper.FilePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None);
                var buffer = new byte[4096];
                var count = 0;
                while ((count = sourceSream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    targetSream.Write(buffer, 0, count);
                }
                result.FileSize = targetSream.Length;
                targetSream.Close();
                sourceSream.Close();
            }
            catch (Exception)
            {
                result.ReturnResult = false;
                return result;
            }
            result.ReturnResult = true;
            return result;
        }

        /// <summary>
        /// 文件下载服务
        /// </summary>
        /// <param name="fileWrapper">FileStreamUpDownService.DownloadFileWrapper</param>
        /// <returns>FileStreamUpDownService.DownloadResult</returns>
        //public Stream DownloadFile(DownloadFileWrapper fileWrapper)
        //{
        //    //DownloadResult result = new DownloadResult();
        //    Stream st = null;
        //    try
        //    {
        //        st = new FileStream(fileWrapper.FilePath,
        //            FileMode.Open, FileAccess.Read, FileShare.None); 
        //        //FileStream fs = new FileStream(fileWrapper.FilePath,
        //        //    FileMode.Open, FileAccess.Read, FileShare.None);
        //        //result.FileData = fs;
        //        //result.FileSize = fs.Length;
        //        return st;
        //    }
        //    catch (Exception)
        //    {
        //        //result.ReturnResult = false;
        //        //return result;
        //        return st;
        //    }
        //    //result.ReturnResult = true;
        //    //return result;
            
        //}

        public Stream DownloadFile()
        {
            Stream st = null;
            string filepath = @"D:\1.jpg";
            try
            {
                st = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.None);
                return st;
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
