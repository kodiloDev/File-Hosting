using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceFile
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
 
    public class FileService : IFileService
    {
        SqlConnectionStringBuilder connectionString;
        //в конструкторе задаются параметры подключения к базе данных
        public FileService()
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "DESKTOP-ERU25D6";
            connectionString.InitialCatalog = "fileBase";
            connectionString.Password = "12345";
            connectionString.UserID = "user";
            connectionString.Encrypt = true;
            connectionString.TrustServerCertificate = true;
            connectionString.ConnectTimeout = 30;
            connectionString.AsynchronousProcessing = true;
            connectionString.MultipleActiveResultSets = true;
            connectionString.IntegratedSecurity = false;
        }
        /// <summary>
        /// проверка соединения
        /// </summary>
        /// <returns> OK </returns>
        public string TestConnection()
        {
            return "OK";
        }
        /// <summary>
        ///  добавление файла в базу
        /// </summary>
        /// <param name="data"> байты файла </param>
        /// <param name="fileName"> имя файла (с расширением) </param>
        /// <param name="contentType"> тип контента </param>
        /// <param name="userId"> Guid пользователя </param>
        /// <returns> результат добавления в базу </returns>
        public bool AddFileInBase(Byte[] data, string fileName, string contentType, Guid userId)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(connectionString.ToString()))
            {
                string strQuery = "Insert into Data(Name, ContentType, Data, Created, UserId) values (@Name, @ContentType, @Data, GETDATE(), @UserId)";

                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = fileName;
                cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = contentType;
                cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = data;
                cmd.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier).Value = userId;

                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            return result;

        }
        /// <summary>
        ///  получение всех файлов пользователя
        /// </summary>
        /// <param name="userId"> Guid пользователя </param>
        public DataTable GetAllFiles(Guid userId)
        {
            DataTable table = new DataTable(userId.ToString());
            
            using (SqlConnection con = new SqlConnection(connectionString.ToString()))
            {
                string strQuery = "SELECT [Id],[ContentType],[Name],[UserId],[Description],[Created], DATALENGTH(Data)/ 1048576.0 AS Data  FROM [Filebase].[dbo].[Data] Where UserId = @UserId";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier).Value = userId;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                da.Dispose();


            }
            
            return table;
        }
        /// <summary>
        ///  получение файла
        /// </summary>
        /// <param name="Id"> Id файла в базе </param>
        ///  <param name="userId"> Guid пользователя </param>
        public byte[] GetFile(int Id, Guid userId)
        {
            byte[] byteFile = null;
            using (SqlConnection con = new SqlConnection(connectionString.ToString()))
            {
                string strQuery = "SELECT Data FROM [Filebase].[dbo].[Data] Where Id = @Id AND UserId = @UserId";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                cmd.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier).Value = userId;
                con.Open();

                using (SqlDataReader d = cmd.ExecuteReader())
                {
                    if (d.Read())
                    {
                        byteFile = (byte[])d["Data"];
                    }
                }
            }
            return byteFile;
        }
        /// <summary>
        ///  удаление файла
        /// </summary>
        /// <param name="fileId"> Id файла в базе </param>
        public bool DeleteFile(int fileId)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(connectionString.ToString()))
            {
                string strQuery = "DELETE FROM [dbo].[Data] WHERE Id = @fileId;"; 
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@fileId", SqlDbType.Int).Value = fileId;

                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        ///  обновление описания файла
        /// </summary>
        /// <param name="fileId"> Id файла в базе </param>
        /// <param name="description"> Описание </param>
        public bool UpdateFileInfo(int fileId, string description)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(connectionString.ToString()))
            {
                string strQuery = "UPDATE [dbo].[Data] SET Description = @description WHERE Id = @fileId;";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@fileId", SqlDbType.Int).Value = fileId;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
            }
            return result;
        }
    }

  
}
