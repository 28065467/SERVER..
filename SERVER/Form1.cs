using SERVER.Connection_Control;
using System.Net.Http.Headers;

namespace SERVER
{
    public partial class Form1 : Form
    {
        public const int PORT = 8080;
        private Connection connection;
        public Form1()
        {
            InitializeComponent();
            tbx_IP.Text = Connection.GetLocalIpAddress();
            tbx_IP.Enabled = false;
            tbx_PORT.Text = PORT.ToString();
            tbx_PORT.Enabled = false;
            list_LOG.Items.Add("The Server is ready to start");
            connection = new Connection(this); // 建立 Connection 物件
        }

        public void ADD_TO_LOG(string message)
        {
            if (list_LOG.InvokeRequired)
            {
                list_LOG.Invoke((MethodInvoker)(() => list_LOG.Items.Add(message)));
            }
            else
            {
                list_LOG.Items.Add(message);
            }
        }
        public void ADD_TO_Recv(string message)
        {
            if (list_Recv.InvokeRequired)
            {
                list_Recv.Invoke((MethodInvoker)(() => list_Recv.Items.Add(message)));
            }
            else
            {
                list_Recv.Items.Add(message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Start_Connecting();
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
