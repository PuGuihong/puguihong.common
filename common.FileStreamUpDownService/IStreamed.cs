using System.ServiceModel;
using System.IO;

namespace common.FileStreamUpDownService
{
    [ServiceContract]
    public interface IStreamed
    {
        /// <summary>
        /// 上传文件
        /// </summary>
        /// 1、支持数据流传输的绑定有：BasicHttpBding、NetTcpBinding和NetNamedPipeBinding
        /// 2、数据流类型必须是可序列化的sream或MemorySream
        /// 3、传递时消息体（Message Body）中不可能包含其他数据，即参数只能有一个streamFileUp.FileWrapper
        /// <param name="fileWrapper">数据载体</param>
        /// <returns></returns>
        [OperationContract]
        UploadResult UploadFile(UploadFileWrapper fileWrapper);
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="fileWrapper"></param>
        /// <returns></returns>
        //[OperationContract]
        //Stream DownloadFile(DownloadFileWrapper fileWrapper);
        [OperationContract]
        Stream DownloadFile();
    }
    #region 文件上传
    [MessageContract]
    public class UploadFileWrapper
    {
        /// <summary>
        ///SOAP的消息头这里即为标记文件的路径
        /// </summary>
        [MessageHeader]
        public string FilePath;
        /// <summary>
        /// SOAP消息的内容，指定成员序列化正文中的元素
        /// </summary>
        [MessageBodyMember]
        public Stream FileData;
    }
    /// <summary>
    /// 消息契约 返回结果
    /// </summary>
    [MessageContract]
    public class UploadResult
    {
        /// <summary>
        /// 消息体 文件上传结果
        /// </summary>
        [MessageBodyMember]
        public bool ReturnResult;
        /// <summary>
        /// 消息体 服务器接收文件大小
        /// </summary>
        [MessageBodyMember]
        public long FileSize;
    }
    #endregion
    #region 文件下载
    //[MessageContract]
    //public class DownloadFileWrapper
    //{
    //    /// <summary>
    //    /// 消息头 服务器文件路径
    //    /// </summary>
    //    [MessageHeader]
    //    public string FilePath;
    //}
    /// <summary>
    /// 消息契约 文件下载结果
    /// </summary>
    //[MessageContract]
    //public class DownloadResult
    //{
    //    /// <summary>
    //    /// 消息头 文件下载结果
    //    /// </summary>
    //    [MessageHeader]
    //    public bool ReturnResult;
    //    /// <summary>
    //    /// 消息头 文件下载大小
    //    /// </summary>
    //    [MessageHeader]
    //    public long FileSize;
    //    /// <summary>
    //    /// 消息体 文件流
    //    /// </summary>
    //    [MessageBodyMember]
    //    public Stream FileData;
    //}
    #endregion
}
