using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage
{
    internal class Account
    {
        /// <summary>
        /// An account class to contain the data for easier transfer
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        public Account(string username, byte[] password, byte[] salt)
        {
            this.Username = username;
            this.Password = password;
            this.Salt = salt;
        }

        public string Username { get; private set; }
        public byte[] Password { get; private set; }
        public byte[] Salt { get; private set; }
    }
}
