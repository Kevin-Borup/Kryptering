namespace WinFormsApp_RSAReciever
{
    partial class RSAReciever
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
            label1 = new Label();
            tbCipherBytes = new TextBox();
            label2 = new Label();
            tbDecrypted = new TextBox();
            label3 = new Label();
            tbModulus = new TextBox();
            tbExponent = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbDP = new TextBox();
            tbD = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbIQ = new TextBox();
            tbDQ = new TextBox();
            tbQ = new TextBox();
            tbP = new TextBox();
            btnRetrieve = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "CipherBytes";
            // 
            // tbCipherBytes
            // 
            tbCipherBytes.Location = new Point(95, 27);
            tbCipherBytes.Name = "tbCipherBytes";
            tbCipherBytes.ReadOnly = true;
            tbCipherBytes.Size = new Size(269, 23);
            tbCipherBytes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Decrypted";
            // 
            // tbDecrypted
            // 
            tbDecrypted.Location = new Point(19, 75);
            tbDecrypted.Name = "tbDecrypted";
            tbDecrypted.ReadOnly = true;
            tbDecrypted.Size = new Size(345, 23);
            tbDecrypted.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 135);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Public Data";
            // 
            // tbModulus
            // 
            tbModulus.Location = new Point(101, 183);
            tbModulus.Name = "tbModulus";
            tbModulus.ReadOnly = true;
            tbModulus.Size = new Size(262, 23);
            tbModulus.TabIndex = 6;
            // 
            // tbExponent
            // 
            tbExponent.Location = new Point(101, 154);
            tbExponent.Name = "tbExponent";
            tbExponent.ReadOnly = true;
            tbExponent.Size = new Size(262, 23);
            tbExponent.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 157);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Exponent:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 191);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Modulus:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 281);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 13;
            label6.Text = "DP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 252);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 12;
            label7.Text = "D:";
            // 
            // tbDP
            // 
            tbDP.Location = new Point(101, 278);
            tbDP.Name = "tbDP";
            tbDP.ReadOnly = true;
            tbDP.Size = new Size(262, 23);
            tbDP.TabIndex = 11;
            // 
            // tbD
            // 
            tbD.Location = new Point(101, 249);
            tbD.Name = "tbD";
            tbD.ReadOnly = true;
            tbD.Size = new Size(262, 23);
            tbD.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 230);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 9;
            label8.Text = "Private Data";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 313);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 14;
            label9.Text = "DQ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 342);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 15;
            label10.Text = "iQ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 371);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 16;
            label11.Text = "P:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 400);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 17;
            label12.Text = "Q:";
            // 
            // tbIQ
            // 
            tbIQ.Location = new Point(101, 339);
            tbIQ.Name = "tbIQ";
            tbIQ.ReadOnly = true;
            tbIQ.Size = new Size(262, 23);
            tbIQ.TabIndex = 19;
            // 
            // tbDQ
            // 
            tbDQ.Location = new Point(101, 310);
            tbDQ.Name = "tbDQ";
            tbDQ.ReadOnly = true;
            tbDQ.Size = new Size(262, 23);
            tbDQ.TabIndex = 18;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(101, 397);
            tbQ.Name = "tbQ";
            tbQ.ReadOnly = true;
            tbQ.Size = new Size(262, 23);
            tbQ.TabIndex = 21;
            // 
            // tbP
            // 
            tbP.Location = new Point(101, 368);
            tbP.Name = "tbP";
            tbP.ReadOnly = true;
            tbP.Size = new Size(262, 23);
            tbP.TabIndex = 20;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(19, 26);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 22;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // RSAReciever
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 439);
            Controls.Add(btnRetrieve);
            Controls.Add(tbQ);
            Controls.Add(tbP);
            Controls.Add(tbIQ);
            Controls.Add(tbDQ);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(tbDP);
            Controls.Add(tbD);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbModulus);
            Controls.Add(tbExponent);
            Controls.Add(label3);
            Controls.Add(tbDecrypted);
            Controls.Add(label2);
            Controls.Add(tbCipherBytes);
            Controls.Add(label1);
            Name = "RSAReciever";
            Text = "PSA Reciever";
            Shown += RSAReciever_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCipherBytes;
        private Label label2;
        private TextBox tbDecrypted;
        private Label label3;
        private TextBox tbModulus;
        private TextBox tbExponent;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbDP;
        private TextBox tbD;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbIQ;
        private TextBox tbDQ;
        private TextBox tbQ;
        private TextBox tbP;
        private Button btnRetrieve;
    }
}