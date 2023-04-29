using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SERVER.Connection_Control
{
    internal class Connection
    {
        private List<Socket> tcpClients;
        private Form1 form;
        private TcpListener listener;
        private Thread connectionThread;
        Thread client_thread;
        Socket client;
        public Connection(Form1 form)
        {
            tcpClients = new List<Socket>();
            this.form = form;
            listener = new TcpListener(IPAddress.Parse(form.tbx_IP.Text), Form1.PORT);
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
            listener.Start();
            form.ADD_TO_LOG("Waiting For Connections");
            connectionThread = new Thread(AcceptConnections);
            connectionThread.IsBackground = true;
            connectionThread.Start();
        }
        private void AcceptConnections()
        {
            while (true)
            {
                client = listener.AcceptSocket();
                tcpClients.Add(client);
                form.ADD_TO_LOG("Client " + client.RemoteEndPoint + " is joined");
                client_thread = new Thread(Client_Listening);
                client_thread.IsBackground = true;
                client_thread.Start(client);
            }
        }
        private void Client_Listening(object clientObj)
        {
            Socket listeningSoc = (Socket)clientObj;
            listeningSoc.Blocking = false;
            //Thread listeningThread = client_thread;
            while (true)
            {
                try
                {
                    if (listeningSoc.Available > 0)
                    {
                        byte[] buffer = new byte[2048];
                        int incoming = listeningSoc.Receive(buffer);
                        string Message_From_Client = Encoding.UTF8.GetString(buffer, 0, incoming);
                        form.ADD_TO_Recv(Message_From_Client);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                catch(Exception ex)
                {

                }
            }
        }

        
    }
}
