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
            command.Parameters.Add("@pws", SqlDbType.VarChar).Value = user.Password;
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

        public bool CheckUsernameAvailability(string name)
        {
            bool validated = false;

            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("CheckUsernameAvailability", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = name;

            command.Parameters.Add("@Available", SqlDbType.Bit);
            command.Parameters["@Available"].Direction = ParameterDirection.Output;

            sqlCon.Open();

            command.ExecuteNonQuery();

            validated = Convert.ToBoolean(command.Parameters["@Available"].Value);

            sqlCon.Close();
            command.Dispose();

            return validated;
        }

        public Account CheckUserCred(string name)
        {
            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("GetUserCredentials", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = name;

            command.Parameters.Add("@pws", SqlDbType.VarChar, 255);
            command.Parameters.Add("@Salt", SqlDbType.VarChar, 30);
            command.Parameters["@pws"].Direction = ParameterDirection.Output;
            command.Parameters["@Salt"].Direction = ParameterDirection.Output;

            sqlCon.Open();

            command.ExecuteNonQuery();

            string pws = Convert.FromBase64String(Convert.ToString(command.Parameters["@pws"].Value));
            string salt = Convert.FromBase64String(command.Parameters["@Salt"].Value);

            sqlCon.Close();
            command.Dispose();

            return new Account(name, pws, salt);
        }
    }
}
