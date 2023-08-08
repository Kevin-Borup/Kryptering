using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage.Models
{
    internal class InformationHandler
    {
        private StorageExchanger _exchanger = new StorageExchanger();

        /// <summary>
        /// Manages the encryption of the password, followed by sending it to the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool StoreUser(string username, string password)
        {
            Encryptor encryptor = new Encryptor();
            encryptor.EncryptPassword(password, out byte[] pass, out byte[] salt);


            Account user = new Account(username, pass, salt);

            return _exchanger.InsertUser(user);
        }

        /// <summary>
        /// Uses the username to aquire the credential values on the database, to then compare the values.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUserCred(string username, string password)
        {
            Encryptor encryptor = new Encryptor();

            Account user = _exchanger.GetUserCred(username);

            return encryptor.CheckPassword(password, user.Password, user.Salt);
        }

        public bool CheckUsername(string username)
        {
            return _exchanger.CheckUsernameAvailability(username);
        }
    }
}
