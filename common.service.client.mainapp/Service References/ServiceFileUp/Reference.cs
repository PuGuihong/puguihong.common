﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace common.service.client.mainapp.ServiceFileUp {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFileUp.IStreamed")]
    public interface IStreamed {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamed/UploadFile", ReplyAction="http://tempuri.org/IStreamed/UploadFileResponse")]
        common.service.client.mainapp.ServiceFileUp.UploadResult UploadFile(common.service.client.mainapp.ServiceFileUp.UploadFileWrapper request);
        
        // CODEGEN: 正在生成消息协定，应为该操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamed/UploadFile", ReplyAction="http://tempuri.org/IStreamed/UploadFileResponse")]
        System.Threading.Tasks.Task<common.service.client.mainapp.ServiceFileUp.UploadResult> UploadFileAsync(common.service.client.mainapp.ServiceFileUp.UploadFileWrapper request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadFileWrapper", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UploadFileWrapper {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FilePath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileData;
        
        public UploadFileWrapper() {
        }
        
        public UploadFileWrapper(string FilePath, System.IO.Stream FileData) {
            this.FilePath = FilePath;
            this.FileData = FileData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UploadResult {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long FileSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public bool ReturnResult;
        
        public UploadResult() {
        }
        
        public UploadResult(long FileSize, bool ReturnResult) {
            this.FileSize = FileSize;
            this.ReturnResult = ReturnResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStreamedChannel : common.service.client.mainapp.ServiceFileUp.IStreamed, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StreamedClient : System.ServiceModel.ClientBase<common.service.client.mainapp.ServiceFileUp.IStreamed>, common.service.client.mainapp.ServiceFileUp.IStreamed {
        
        public StreamedClient() {
        }
        
        public StreamedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StreamedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StreamedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StreamedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        common.service.client.mainapp.ServiceFileUp.UploadResult common.service.client.mainapp.ServiceFileUp.IStreamed.UploadFile(common.service.client.mainapp.ServiceFileUp.UploadFileWrapper request) {
            return base.Channel.UploadFile(request);
        }
        
        public long UploadFile(string FilePath, System.IO.Stream FileData, out bool ReturnResult) {
            common.service.client.mainapp.ServiceFileUp.UploadFileWrapper inValue = new common.service.client.mainapp.ServiceFileUp.UploadFileWrapper();
            inValue.FilePath = FilePath;
            inValue.FileData = FileData;
            common.service.client.mainapp.ServiceFileUp.UploadResult retVal = ((common.service.client.mainapp.ServiceFileUp.IStreamed)(this)).UploadFile(inValue);
            ReturnResult = retVal.ReturnResult;
            return retVal.FileSize;
        }
        
        public System.Threading.Tasks.Task<common.service.client.mainapp.ServiceFileUp.UploadResult> UploadFileAsync(common.service.client.mainapp.ServiceFileUp.UploadFileWrapper request) {
            return base.Channel.UploadFileAsync(request);
        }
    }
}
