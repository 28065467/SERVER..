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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            tbx_IP = new TextBox();
            tbx_PORT = new TextBox();
            listView1 = new ListView();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "SERVER IP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 113);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "SERVER PORT";
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
            // listView1
            // 
            listView1.Location = new Point(74, 188);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 231);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(tbx_PORT);
            Controls.Add(tbx_IP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        protected TextBox tbx_IP;
        protected TextBox tbx_PORT;
        private ListView listView1;
    }
}