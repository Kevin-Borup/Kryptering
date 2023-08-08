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
            encryptor.EncryptPassword(password, out string pass, out byte[] salt);


            Account user = new Account(username, pass, salt);
        }

        public bool CheckUser()
        {

        }
        


        
    }
}
