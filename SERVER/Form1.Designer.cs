namespace SERVER
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_IP = new System.Windows.Forms.TextBox();
            this.tbx_PORT = new System.Windows.Forms.TextBox();
            this.list_LOG = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Recv = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "SERVER START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_IP
            // 
            this.tbx_IP.Location = new System.Drawing.Point(480, 54);
            this.tbx_IP.Name = "tbx_IP";
            this.tbx_IP.Size = new System.Drawing.Size(100, 23);
            this.tbx_IP.TabIndex = 3;
            // 
            // tbx_PORT
            // 
            this.tbx_PORT.Location = new System.Drawing.Point(480, 105);
            this.tbx_PORT.Name = "tbx_PORT";
            this.tbx_PORT.Size = new System.Drawing.Size(100, 23);
            this.tbx_PORT.TabIndex = 4;
            // 
            // list_LOG
            // 
            this.list_LOG.FormattingEnabled = true;
            this.list_LOG.ItemHeight = 15;
            this.list_LOG.Location = new System.Drawing.Point(12, 227);
            this.list_LOG.Name = "list_LOG";
            this.list_LOG.Size = new System.Drawing.Size(343, 184);
            this.list_LOG.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Server PORT";
            // 
            // list_Recv
            // 
            this.list_Recv.FormattingEnabled = true;
            this.list_Recv.ItemHeight = 15;
            this.list_Recv.Location = new System.Drawing.Point(416, 227);
            this.list_Recv.Name = "list_Recv";
            this.list_Recv.Size = new System.Drawing.Size(316, 184);
            this.list_Recv.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Received Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "ServerLog";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Server STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_Recv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_LOG);
            this.Controls.Add(this.tbx_PORT);
            this.Controls.Add(this.tbx_IP);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        public TextBox tbx_IP;
        public TextBox tbx_PORT;
        private ListBox list_LOG;
        private Label label2;
        private Label label3;
        private ListBox list_Recv;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}