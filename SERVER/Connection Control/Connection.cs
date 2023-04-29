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
    internal class Connection : Form1
    {

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
            TcpListener listener = new TcpListener(IPAddress.Parse(tbx_IP.Text), PORT);
            tbx_PORT.Text = (((IPEndPoint)listener.LocalEndpoint).Port).ToString();
        }
    }
}
