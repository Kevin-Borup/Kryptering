namespace WinFormsApp_PasswordStorage
{
    partial class RegistrationPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            tbPassword = new TextBox();
            label3 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            lblNameFeedback = new Label();
            lblPassFeedback = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 1;
            label1.Text = "Registration Page";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(16, 190);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(268, 190);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Go to Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(20, 132);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(188, 23);
            tbPassword.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(20, 65);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(188, 23);
            tbUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 47);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // lblNameFeedback
            // 
            lblNameFeedback.AutoSize = true;
            lblNameFeedback.ForeColor = Color.Brown;
            lblNameFeedback.Location = new Point(20, 91);
            lblNameFeedback.Name = "lblNameFeedback";
            lblNameFeedback.Size = new Size(87, 15);
            lblNameFeedback.TabIndex = 13;
            lblNameFeedback.Text = "nameFeedback";
            // 
            // lblPassFeedback
            // 
            lblPassFeedback.AutoSize = true;
            lblPassFeedback.ForeColor = Color.Brown;
            lblPassFeedback.Location = new Point(20, 158);
            lblPassFeedback.Name = "lblPassFeedback";
            lblPassFeedback.Size = new Size(80, 15);
            lblPassFeedback.TabIndex = 14;
            lblPassFeedback.Text = "passFeedback";
            // 
            // RegistrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPassFeedback);
            Controls.Add(lblNameFeedback);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationPage";
            Size = new Size(370, 226);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbUsername;
        private Label label2;
        private Label lblNameFeedback;
        private Label lblPassFeedback;
    }
}
