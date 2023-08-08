using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_PasswordStorage.Models;

namespace WinFormsApp_PasswordStorage
{
    public partial class AccountPage : ChangePageControl
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChangePage(Page.Login);
        }
    }
}
