namespace WinFormsApp_SymmetricEncryption
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbEncryptType = new ComboBox();
            label1 = new Label();
            lblKey = new Label();
            tbKey = new TextBox();
            tbIV = new TextBox();
            lblIV = new Label();
            btnEncrypt = new Button();
            tbPlainHEX = new TextBox();
            tbPlainASCII = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbDecryptedHEX = new TextBox();
            tbDecryptedASCII = new TextBox();
            btnDecrypt = new Button();
            lblEncryptTime = new Label();
            lblDecryptTime = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbCipherHEX = new TextBox();
            tbCipherASCII = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // cbEncryptType
            // 
            cbEncryptType.FormattingEnabled = true;
            cbEncryptType.Location = new Point(29, 34);
            cbEncryptType.Name = "cbEncryptType";
            cbEncryptType.Size = new Size(121, 23);
            cbEncryptType.TabIndex = 0;
            cbEncryptType.SelectedIndexChanged += cbEncryptType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 16);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Encryption Types";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(223, 16);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(26, 15);
            lblKey.TabIndex = 3;
            lblKey.Text = "Key";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(223, 34);
            tbKey.Name = "tbKey";
            tbKey.ReadOnly = true;
            tbKey.Size = new Size(452, 23);
            tbKey.TabIndex = 4;
            // 
            // tbIV
            // 
            tbIV.Location = new Point(223, 84);
            tbIV.Name = "tbIV";
            tbIV.ReadOnly = true;
            tbIV.Size = new Size(452, 23);
            tbIV.TabIndex = 6;
            // 
            // lblIV
            // 
            lblIV.AutoSize = true;
            lblIV.Location = new Point(223, 66);
            lblIV.Name = "lblIV";
            lblIV.Size = new Size(17, 15);
            lblIV.TabIndex = 5;
            lblIV.Text = "IV";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(29, 148);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(121, 23);
            btnEncrypt.TabIndex = 7;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // tbPlainHEX
            // 
            tbPlainHEX.Location = new Point(223, 178);
            tbPlainHEX.Name = "tbPlainHEX";
            tbPlainHEX.ReadOnly = true;
            tbPlainHEX.Size = new Size(452, 23);
            tbPlainHEX.TabIndex = 9;
            // 
            // tbPlainASCII
            // 
            tbPlainASCII.Location = new Point(223, 149);
            tbPlainASCII.Name = "tbPlainASCII";
            tbPlainASCII.Size = new Size(452, 23);
            tbPlainASCII.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 131);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "PlainText";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 152);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "ASCII";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 181);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 12;
            label6.Text = "HEX";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 377);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 18;
            label7.Text = "HEX";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 348);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 17;
            label8.Text = "ASCII";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(223, 327);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 16;
            label9.Text = "DecryptedText";
            // 
            // tbDecryptedHEX
            // 
            tbDecryptedHEX.Location = new Point(223, 374);
            tbDecryptedHEX.Name = "tbDecryptedHEX";
            tbDecryptedHEX.ReadOnly = true;
            tbDecryptedHEX.Size = new Size(452, 23);
            tbDecryptedHEX.TabIndex = 15;
            // 
            // tbDecryptedASCII
            // 
            tbDecryptedASCII.Location = new Point(223, 345);
            tbDecryptedASCII.Name = "tbDecryptedASCII";
            tbDecryptedASCII.ReadOnly = true;
            tbDecryptedASCII.Size = new Size(452, 23);
            tbDecryptedASCII.TabIndex = 14;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(29, 344);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(121, 23);
            btnDecrypt.TabIndex = 13;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // lblEncryptTime
            // 
            lblEncryptTime.AutoSize = true;
            lblEncryptTime.Location = new Point(29, 174);
            lblEncryptTime.Name = "lblEncryptTime";
            lblEncryptTime.Size = new Size(96, 15);
            lblEncryptTime.TabIndex = 19;
            lblEncryptTime.Text = "Encryption Time:";
            // 
            // lblDecryptTime
            // 
            lblDecryptTime.AutoSize = true;
            lblDecryptTime.Location = new Point(29, 370);
            lblDecryptTime.Name = "lblDecryptTime";
            lblDecryptTime.Size = new Size(97, 15);
            lblDecryptTime.TabIndex = 20;
            lblDecryptTime.Text = "Decryption Time:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 279);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 25;
            label10.Text = "HEX";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(182, 250);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 24;
            label11.Text = "ASCII";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(223, 229);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 23;
            label12.Text = "CipherText";
            // 
            // tbCipherHEX
            // 
            tbCipherHEX.Location = new Point(223, 276);
            tbCipherHEX.Name = "tbCipherHEX";
            tbCipherHEX.ReadOnly = true;
            tbCipherHEX.Size = new Size(452, 23);
            tbCipherHEX.TabIndex = 22;
            // 
            // tbCipherASCII
            // 
            tbCipherASCII.Location = new Point(223, 247);
            tbCipherASCII.Name = "tbCipherASCII";
            tbCipherASCII.ReadOnly = true;
            tbCipherASCII.Size = new Size(452, 23);
            tbCipherASCII.TabIndex = 21;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Brown;
            lblErrorMsg.Location = new Point(37, 243);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(100, 15);
            lblErrorMsg.TabIndex = 26;
            lblErrorMsg.Text = "An error occurred";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 409);
            Controls.Add(lblErrorMsg);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(tbCipherHEX);
            Controls.Add(tbCipherASCII);
            Controls.Add(lblDecryptTime);
            Controls.Add(lblEncryptTime);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(tbDecryptedHEX);
            Controls.Add(tbDecryptedASCII);
            Controls.Add(btnDecrypt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbPlainHEX);
            Controls.Add(tbPlainASCII);
            Controls.Add(btnEncrypt);
            Controls.Add(tbIV);
            Controls.Add(lblIV);
            Controls.Add(tbKey);
            Controls.Add(lblKey);
            Controls.Add(label1);
            Controls.Add(cbEncryptType);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEncryptType;
        private Label label1;
        private Label lblKey;
        private TextBox tbKey;
        private TextBox tbIV;
        private Label lblIV;
        private Button btnEncrypt;
        private TextBox tbPlainHEX;
        private TextBox tbPlainASCII;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbDecryptedHEX;
        private TextBox tbDecryptedASCII;
        private Button btnDecrypt;
        private Label lblEncryptTime;
        private Label lblDecryptTime;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbCipherHEX;
        private TextBox tbCipherASCII;
        private Label lblErrorMsg;
    }
}