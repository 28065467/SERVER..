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
            tbx_PORT.Text = PORT.ToString();
            list_LOG.Items.Add("The Server is ready to start");
            connection = new Connection(this); // 建立 Connection 物件
        }

        public void ADD_TO_LOG(string message)
        {
            list_LOG.Items.Add(message);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Start_Connecting();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
