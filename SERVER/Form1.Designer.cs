﻿namespace SERVER
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
            button1 = new Button();
            tbx_IP = new TextBox();
            tbx_PORT = new TextBox();
            list_LOG = new ListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 18);
            button1.Name = "button1";
            button1.Size = new Size(106, 59);
            button1.TabIndex = 0;
            button1.Text = "SERVER START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbx_IP
            // 
            tbx_IP.Location = new Point(480, 54);
            tbx_IP.Name = "tbx_IP";
            tbx_IP.Size = new Size(100, 23);
            tbx_IP.TabIndex = 3;
            tbx_IP.TextChanged += textBox1_TextChanged;
            // 
            // tbx_PORT
            // 
            tbx_PORT.Location = new Point(480, 105);
            tbx_PORT.Name = "tbx_PORT";
            tbx_PORT.Size = new Size(100, 23);
            tbx_PORT.TabIndex = 4;
            // 
            // list_LOG
            // 
            list_LOG.FormattingEnabled = true;
            list_LOG.ItemHeight = 15;
            list_LOG.Location = new Point(20, 215);
            list_LOG.Name = "list_LOG";
            list_LOG.Size = new Size(403, 229);
            list_LOG.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Server IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 8;
            label3.Text = "Server PORT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(list_LOG);
            Controls.Add(tbx_PORT);
            Controls.Add(tbx_IP);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        public TextBox tbx_IP;
        public TextBox tbx_PORT;
        private ListBox list_LOG;
        private Label label2;
        private Label label3;
    }
}