﻿namespace WinFormsApp_PasswordStorage
{
    partial class MainWindow
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
            PageContainer = new GroupBox();
            SuspendLayout();
            // 
            // PageContainer
            // 
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Location = new Point(0, 0);
            PageContainer.Name = "PageContainer";
            PageContainer.Size = new Size(483, 337);
            PageContainer.TabIndex = 0;
            PageContainer.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 337);
            Controls.Add(PageContainer);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PageContainer;
    }
}