using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_PasswordStorage
{
    public partial class RegistrationPage : ChangePageControl
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChangePage(Page.Login);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                bool succes = false;

                if (succes)
                {
                    ChangePage(Page.Account);
                }
            }
        }
    }
}
