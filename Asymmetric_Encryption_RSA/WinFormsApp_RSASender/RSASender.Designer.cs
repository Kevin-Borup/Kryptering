namespace WinFormsApp_RSASender
{
    partial class RSASender
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbExponent = new TextBox();
            tbModulus = new TextBox();
            label4 = new Label();
            tbPlainText = new TextBox();
            tbCipherText = new TextBox();
            label5 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 122);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Public Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 148);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Exponent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Modulus:";
            // 
            // tbExponent
            // 
            tbExponent.Location = new Point(103, 145);
            tbExponent.Name = "tbExponent";
            tbExponent.ReadOnly = true;
            tbExponent.Size = new Size(268, 23);
            tbExponent.TabIndex = 3;
            // 
            // tbModulus
            // 
            tbModulus.Location = new Point(103, 171);
            tbModulus.Name = "tbModulus";
            tbModulus.ReadOnly = true;
            tbModulus.Size = new Size(268, 23);
            tbModulus.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "PlainText";
            // 
            // tbPlainText
            // 
            tbPlainText.Location = new Point(16, 27);
            tbPlainText.Name = "tbPlainText";
            tbPlainText.Size = new Size(276, 23);
            tbPlainText.TabIndex = 6;
            tbPlainText.KeyDown += tbPlainText_KeyDown;
            // 
            // tbCipherText
            // 
            tbCipherText.Location = new Point(16, 81);
            tbCipherText.Name = "tbCipherText";
            tbCipherText.ReadOnly = true;
            tbCipherText.Size = new Size(355, 23);
            tbCipherText.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 63);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "CipherText";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(296, 26);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 217);
            Controls.Add(btnSend);
            Controls.Add(tbCipherText);
            Controls.Add(label5);
            Controls.Add(tbPlainText);
            Controls.Add(label4);
            Controls.Add(tbModulus);
            Controls.Add(tbExponent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbExponent;
        private TextBox tbModulus;
        private Label label4;
        private TextBox tbPlainText;
        private TextBox tbCipherText;
        private Label label5;
        private Button btnSend;
    }
}