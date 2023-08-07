namespace WinFormsApp_Hashing
{
    partial class Form1
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
            cbEncryptionTypes = new ComboBox();
            label1 = new Label();
            btnComputeMAC = new Button();
            tbKeyInput = new TextBox();
            label2 = new Label();
            tbTextInput = new TextBox();
            label3 = new Label();
            btnEncrypt = new Button();
            tbASCIIOutput = new TextBox();
            tbHexOutput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            tbMACOutput = new TextBox();
            SuspendLayout();
            // 
            // cbEncryptionTypes
            // 
            cbEncryptionTypes.FormattingEnabled = true;
            cbEncryptionTypes.Location = new Point(23, 37);
            cbEncryptionTypes.Name = "cbEncryptionTypes";
            cbEncryptionTypes.Size = new Size(121, 23);
            cbEncryptionTypes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Encryption Type";
            // 
            // btnComputeMAC
            // 
            btnComputeMAC.Location = new Point(23, 128);
            btnComputeMAC.Name = "btnComputeMAC";
            btnComputeMAC.Size = new Size(121, 23);
            btnComputeMAC.TabIndex = 2;
            btnComputeMAC.Text = "Compute MAC";
            btnComputeMAC.UseVisualStyleBackColor = true;
            btnComputeMAC.Click += btnComputeMAC_Click;
            // 
            // tbKeyInput
            // 
            tbKeyInput.Location = new Point(23, 99);
            tbKeyInput.Name = "tbKeyInput";
            tbKeyInput.Size = new Size(245, 23);
            tbKeyInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 4;
            label2.Text = "Key";
            // 
            // tbTextInput
            // 
            tbTextInput.Location = new Point(23, 193);
            tbTextInput.Name = "tbTextInput";
            tbTextInput.Size = new Size(245, 23);
            tbTextInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Plain Text";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(23, 236);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(245, 23);
            btnEncrypt.TabIndex = 7;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // tbASCIIOutput
            // 
            tbASCIIOutput.Location = new Point(23, 359);
            tbASCIIOutput.Name = "tbASCIIOutput";
            tbASCIIOutput.ReadOnly = true;
            tbASCIIOutput.Size = new Size(245, 23);
            tbASCIIOutput.TabIndex = 8;
            // 
            // tbHexOutput
            // 
            tbHexOutput.Location = new Point(23, 418);
            tbHexOutput.Name = "tbHexOutput";
            tbHexOutput.ReadOnly = true;
            tbHexOutput.Size = new Size(245, 23);
            tbHexOutput.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 175);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "ASCII";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 400);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 11;
            label5.Text = "HEX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 81);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 12;
            label6.Text = "ASCII";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 341);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 13;
            label7.Text = "ASCII";
            // 
            // button1
            // 
            button1.Location = new Point(147, 128);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 14;
            button1.Text = "Check MAC";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 278);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 16;
            label8.Text = "MAC Key";
            // 
            // tbMACOutput
            // 
            tbMACOutput.Location = new Point(23, 296);
            tbMACOutput.Name = "tbMACOutput";
            tbMACOutput.ReadOnly = true;
            tbMACOutput.Size = new Size(245, 23);
            tbMACOutput.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 455);
            Controls.Add(label8);
            Controls.Add(tbMACOutput);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbHexOutput);
            Controls.Add(tbASCIIOutput);
            Controls.Add(btnEncrypt);
            Controls.Add(label3);
            Controls.Add(tbTextInput);
            Controls.Add(label2);
            Controls.Add(tbKeyInput);
            Controls.Add(btnComputeMAC);
            Controls.Add(label1);
            Controls.Add(cbEncryptionTypes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEncryptionTypes;
        private Label label1;
        private Button btnComputeMAC;
        private TextBox tbKeyInput;
        private Label label2;
        private TextBox tbTextInput;
        private Label label3;
        private Button btnEncrypt;
        private TextBox tbASCIIOutput;
        private TextBox tbHexOutput;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private TextBox tbMACOutput;
    }
}