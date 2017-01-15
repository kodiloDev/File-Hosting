﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/WcfServiceFile", ConfigurationName="ServiceReference1.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/TestConnection", ReplyAction="http://localhost/WcfServiceFile/IFileService/TestConnectionResponse")]
        string TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/TestConnection", ReplyAction="http://localhost/WcfServiceFile/IFileService/TestConnectionResponse")]
        System.Threading.Tasks.Task<string> TestConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/AddFileInBase", ReplyAction="http://localhost/WcfServiceFile/IFileService/AddFileInBaseResponse")]
        bool AddFileInBase(byte[] data, string fileName, string contentType, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/AddFileInBase", ReplyAction="http://localhost/WcfServiceFile/IFileService/AddFileInBaseResponse")]
        System.Threading.Tasks.Task<bool> AddFileInBaseAsync(byte[] data, string fileName, string contentType, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/GetAllFiles", ReplyAction="http://localhost/WcfServiceFile/IFileService/GetAllFilesResponse")]
        System.Data.DataTable GetAllFiles(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/GetAllFiles", ReplyAction="http://localhost/WcfServiceFile/IFileService/GetAllFilesResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAllFilesAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/DeleteFile", ReplyAction="http://localhost/WcfServiceFile/IFileService/DeleteFileResponse")]
        bool DeleteFile(int fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/DeleteFile", ReplyAction="http://localhost/WcfServiceFile/IFileService/DeleteFileResponse")]
        System.Threading.Tasks.Task<bool> DeleteFileAsync(int fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/UpdateFileInfo", ReplyAction="http://localhost/WcfServiceFile/IFileService/UpdateFileInfoResponse")]
        bool UpdateFileInfo(int fileId, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/UpdateFileInfo", ReplyAction="http://localhost/WcfServiceFile/IFileService/UpdateFileInfoResponse")]
        System.Threading.Tasks.Task<bool> UpdateFileInfoAsync(int fileId, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/GetFile", ReplyAction="http://localhost/WcfServiceFile/IFileService/GetFileResponse")]
        byte[] GetFile(int Id, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WcfServiceFile/IFileService/GetFile", ReplyAction="http://localhost/WcfServiceFile/IFileService/GetFileResponse")]
        System.Threading.Tasks.Task<byte[]> GetFileAsync(int Id, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : FileClient.ServiceReference1.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<FileClient.ServiceReference1.IFileService>, FileClient.ServiceReference1.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TestConnection() {
            return base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task<string> TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
        
        public bool AddFileInBase(byte[] data, string fileName, string contentType, System.Guid userId) {
            return base.Channel.AddFileInBase(data, fileName, contentType, userId);
        }
        
        public System.Threading.Tasks.Task<bool> AddFileInBaseAsync(byte[] data, string fileName, string contentType, System.Guid userId) {
            return base.Channel.AddFileInBaseAsync(data, fileName, contentType, userId);
        }
        
        public System.Data.DataTable GetAllFiles(System.Guid userId) {
            return base.Channel.GetAllFiles(userId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAllFilesAsync(System.Guid userId) {
            return base.Channel.GetAllFilesAsync(userId);
        }
        
        public bool DeleteFile(int fileId) {
            return base.Channel.DeleteFile(fileId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteFileAsync(int fileId) {
            return base.Channel.DeleteFileAsync(fileId);
        }
        
        public bool UpdateFileInfo(int fileId, string description) {
            return base.Channel.UpdateFileInfo(fileId, description);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateFileInfoAsync(int fileId, string description) {
            return base.Channel.UpdateFileInfoAsync(fileId, description);
        }
        
        public byte[] GetFile(int Id, System.Guid userId) {
            return base.Channel.GetFile(Id, userId);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetFileAsync(int Id, System.Guid userId) {
            return base.Channel.GetFileAsync(Id, userId);
        }
    }
}
