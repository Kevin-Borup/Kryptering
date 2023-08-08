namespace WinFormsApp_PasswordStorage
{
    partial class LoginPage
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
            label2 = new Label();
            tbUsername = new TextBox();
            label3 = new Label();
            tbPassword = new TextBox();
            btnRegistration = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Login Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(19, 67);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(188, 23);
            tbUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(19, 129);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(188, 23);
            tbPassword.TabIndex = 4;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(237, 176);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(123, 23);
            btnRegistration.TabIndex = 5;
            btnRegistration.Text = "Go to Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(20, 176);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogin);
            Controls.Add(btnRegistration);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Size = new Size(374, 209);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private Label label3;
        private TextBox tbPassword;
        private Button btnRegistration;
        private Button btnLogin;
    }
}
