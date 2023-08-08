using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage
{
    internal class Account
    {
        public Account(string username, string password, byte[] salt)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public byte[] Salt { get; private set; }
    }
}
