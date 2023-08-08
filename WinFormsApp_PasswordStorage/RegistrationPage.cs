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

            tbUsername.KeyDown += textBox_KeyDown;
            tbPassword.KeyDown += textBox_KeyDown;

            ResetUI();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChangePage(Page.Login);
        }

        private void ResetUI()
        {
            lblNameFeedback.Visible = false;
            lblPassFeedback.Visible = false;
        }

        private void textBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRegister.PerformClick();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ResetUI();

            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                lblNameFeedback.Text = "Type a username";
                lblNameFeedback.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                lblPassFeedback.Text = "Type a password";
                lblPassFeedback.Visible = true;
            }
            else
            {
                try
                {
                    InformationHandler infoHandler = new InformationHandler();
                    //Check if the name doesn't exist.
                    if (infoHandler.CheckUsername(username))
                    {
                        // Attempt to store the new user, as the name is available.
                        if (infoHandler.StoreUser(username, password))
                        {
                            ChangePage(Page.Account);
                        }
                    }
                    else
                    {
                        lblNameFeedback.Text = "The username is already in use";
                        lblNameFeedback.Visible = true;
                    }
                }
                catch (Exception)
                {
                    lblPassFeedback.Text = "An error occurred";
                    lblPassFeedback.Visible = true;
                }
            }
        }
    }
}
