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
    public partial class LoginPage : ChangePageControl
    {
        public LoginPage()
        {
            InitializeComponent();

            tbUsername.KeyDown += textBox_KeyDown;
            tbPassword.KeyDown += textBox_KeyDown;

            ResetUI();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // Change the page to registration
            ChangePage(Page.Registration);
        }

        private void ResetUI()
        {
            lblNameFeedback.Visible = false;
            lblPassFeedback.Visible = false;
        }

        private void textBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                    // Check if the username doesn't exist, if it does, flip the result.
                    // The name shouldn't be available.
                    if (!infoHandler.CheckUsername(username))
                    {
                        // Check if the existing users typed password, matched the one stored.
                        if (infoHandler.CheckUserCred(username, password))
                        {
                            ChangePage(Page.Account);
                        }
                        else
                        {
                            lblPassFeedback.Text = "The password is incorrect";
                            lblPassFeedback.Visible = true;
                        }
                    }
                    else
                    {
                        lblNameFeedback.Text = "The username doesn't exist";
                        lblNameFeedback.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblPassFeedback.Text = "An error occurred";
                    lblPassFeedback.Visible = true;
                }
            }
        }
    }
}
