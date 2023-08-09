using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinFormsApp_PasswordStorage.Models
{
    internal class StorageExchanger
    {
        // A more readable variable to store the connection parameters.
        private readonly SqlConnectionStringBuilder databaseStorage = new SqlConnectionStringBuilder();

        public StorageExchanger()
        {
            databaseStorage.DataSource = @"MOBILE-ORBIT\SQL2019";
            databaseStorage.InitialCatalog = "EncryptionBase";
            databaseStorage.PersistSecurityInfo = true;
            databaseStorage.UserID = "EncryptionBaseUser";
            databaseStorage.Password = "Kode1234!";
        }

        /// <summary>
        /// Insert the user information into the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool InsertUser(Account user)
        {
            bool successful = false;

            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("InsertUser", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            string password = Convert.ToBase64String(user.Password);
            string salt = Convert.ToBase64String(user.Salt);

            // Debugging to calculate the length of base64 string of a hashed password. Used to alocate space in the server.
            //double base64length = password.Length;

            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@pws", password);
            command.Parameters.AddWithValue("@Salt", salt);

            sqlCon.Open();

            // Returns the amount of affected rows, used to check if the procedure was successful.
            int rowsAffected = command.ExecuteNonQuery();

            sqlCon.Close();
            command.Dispose();

            if (rowsAffected > 0)
            {
                successful = true;
            }

            return successful;
        }

        /// <summary>
        /// Checks if the name exists in the database. If it doesn't, true is return to signify availablity.
        /// Used in reverse to check if the name exists
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckUsernameAvailability(string name)
        {
            bool validated = false;

            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("CheckUsernameAvailability", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Username", name);

            command.Parameters.Add("@Available", SqlDbType.Bit).Direction = ParameterDirection.Output;

            sqlCon.Open();

            command.ExecuteNonQuery();

            validated = Convert.ToBoolean(command.Parameters["@Available"].Value);

            sqlCon.Close();
            command.Dispose();

            return validated;
        }

        /// <summary>
        /// Gets the credential values associated with the username. Used to compare with the inputtet password.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Account GetUserCred(string name)
        {
            SqlConnection sqlCon = new SqlConnection(databaseStorage.ConnectionString);

            SqlCommand command = new SqlCommand("GetUserCredentials", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@Username", name);

            // Base64 af hash pass bruger altid 44. Nvarchar tilader at en karakter kan tage 2 bits og udvider sig efter det.
            command.Parameters.Add("@pws", SqlDbType.NVarChar, 44).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Salt", SqlDbType.NVarChar, 44).Direction = ParameterDirection.Output;

            sqlCon.Open();

            command.ExecuteNonQuery();

            byte[] pws = Convert.FromBase64String(Convert.ToString(command.Parameters["@pws"].Value));
            byte[] salt = Convert.FromBase64String(Convert.ToString(command.Parameters["@Salt"].Value));

            sqlCon.Close();
            command.Dispose();

            return new Account(name, pws, salt);
        }
    }
}
