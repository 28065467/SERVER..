using  SERVER.Connection_Control;
namespace SERVER
{
    public partial class Form1 : Form
    {
        public const int PORT = 8080;
        public Form1()
        {
            InitializeComponent();
            tbx_IP.Text = Connection.GetLocalIpAddress();
            tbx_PORT.Text = PORT.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}