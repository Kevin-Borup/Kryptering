using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp_PasswordStorage
{
    internal class InformationHandler
    {
        private StorageExchanger _exchanger = new StorageExchanger();

        public bool StoreUser(string username, string password)
        {
            Encryptor encryptor = new Encryptor();
            encryptor.EncryptPassword(password, out string pass, out string salt);


            Account user = new Account(username, pass, salt);

            return _exchanger.InsertUser(user);
        }

        public bool CheckUserCred(string username, string password)
        {
            Encryptor encryptor = new Encryptor();

            Account user = _exchanger.CheckUserCred(username);

            return encryptor.CheckPassword(password, user.Password, user.Salt);
        }

        public bool CheckUsername(string username)
        {
            return _exchanger.CheckUsernameAvailability(username);
        }
        


        
    }
}
