using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp_PasswordStorage
{
    internal class StorageExchanger
    {
        private readonly SqlConnectionStringBuilder databaseStorage = new SqlConnectionStringBuilder();

        public StorageExchanger()
        {
            databaseStorage.DataSource = @"MOBILE-ORBIT\SQL2019";
            databaseStorage.InitialCatalog = "EncryptionBase";
            databaseStorage.PersistSecurityInfo = true;
            databaseStorage.UserID = "EncryptionBaseUser";
            databaseStorage.Password = "Kode1234!";
        }

        public bool InsertUser(Account user)
        {
            bool successful = false;

            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("InsertUser", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;
            command.Parameters.Add("@Salt", SqlDbType.VarChar).Value = user.Salt;

            sqlCon.Open();

            int rowsAffected = command.ExecuteNonQuery();

            sqlCon.Close();
            command.Dispose();

            if (rowsAffected > 0)
            {
                successful = true;
            }

            return successful;
        }

        public bool CheckUser(Account user)
        {
            bool validated = false;

            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("CheckUser", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.Username;

            sqlCon.Open();

            command.ExecuteNonQuery();

            sqlCon.Close();
            command.Dispose();

            return validated;
        }
    }
}
