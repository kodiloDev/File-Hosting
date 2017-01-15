using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceFile
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(Namespace = "http://localhost/WcfServiceFile")]
    public interface IFileService
    {

        #region Common Methods

        /// <summary>
        /// проверка соединения
        /// </summary>
        /// <returns> OK </returns>
        [OperationContract]
        string TestConnection();

        #endregion


        // TODO: Добавьте здесь операции служб

        [OperationContract]
        bool AddFileInBase(Byte[] data, string fileName, string contentType, Guid userId);

        [OperationContract]
        DataTable GetAllFiles(Guid userId);


        [OperationContract]
        bool DeleteFile(int fileId);

        [OperationContract]
        bool UpdateFileInfo(int fileId, string description);

        [OperationContract]
        byte[] GetFile(int Id, Guid userId);
    }


   
}
