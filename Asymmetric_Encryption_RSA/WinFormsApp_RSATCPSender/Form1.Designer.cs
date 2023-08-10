namespace WinFormsApp_RSATCPSender
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
            tbPlainText = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbPlainText
            // 
            tbPlainText.Location = new Point(51, 51);
            tbPlainText.Name = "tbPlainText";
            tbPlainText.Size = new Size(188, 23);
            tbPlainText.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(245, 51);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Outgoing Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(tbPlainText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPlainText;
        private Button btnSend;
        private Label label1;
    }
}