using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SERVER;
namespace SERVER.Connection_Control
{
    internal class Connection
    {
        private List<TcpClient> tcpClients;
        private Form1 form;
        public Connection(Form1 form)
        {
            tcpClients = new List<TcpClient>();
            this.form = form;
        }
        public static string GetLocalIpAddress()
        {
            string ipAddress = string.Empty;
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var address in hostEntry.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }
            return "127.0.0.1";
        }
        public void Start_Connecting()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(form.tbx_IP.Text), Form1.PORT);
            listener.Start();
            form.ADD_TO_LOG("Waiting For Connections");
            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    tcpClients.Add(client);
                    form.Invoke((MethodInvoker)(() => form.ADD_TO_LOG("Client " + client.Client.RemoteEndPoint + " is joined")));
                }
            });
        }
    }
}
