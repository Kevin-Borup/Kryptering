using Microsoft.VisualBasic.Logging;
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
    public partial class MainWindow : Form
    {
        LoginPage loginPage = new LoginPage();
        RegistrationPage registrationPage = new RegistrationPage();
        AccountPage accountPage = new AccountPage();

        Navigator navigator;

        public MainWindow()
        {
            InitializeComponent();
            navigator = new Navigator(this.PageContainer);

            loginPage.ChangePageEvent += ChangePageEvent;
            registrationPage.ChangePageEvent += ChangePageEvent;
            accountPage.ChangePageEvent += ChangePageEvent;

            navigator.ChangePage(loginPage);
        }

        private void ChangePageEvent(object sender, ChangePageEventArgs e)
        {
            //Changes the page based on the recieved Page enum
            switch (e.Page)
            {
                case Page.Login:
                    navigator.ChangePage(loginPage);
                    break;
                case Page.Registration:
                    navigator.ChangePage(registrationPage);
                    break;
                case Page.Account:
                    navigator.ChangePage(accountPage);
                    break;
                default:
                    break;
            }
        }
    }
}
