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
        private List<TcpClient> tcpClients;
        private Form1 form;
        private TcpListener listener;
        private Thread connectionThread;
        Thread client_thread;
        Socket client;
        public Connection(Form1 form)
        {
            tcpClients = new List<TcpClient>();
            this.form = form;
            listener = new TcpListener(IPAddress.Parse(form.tbx_IP.Text), 8080);
            IPEndPoint ipe = (IPEndPoint)listener.LocalEndpoint;
            form.ADD_TO_LOG("Listening At " + ipe.Address  + ":" + ipe.Port);
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
            TcpClient temp;
            while (true)
            {
                temp = listener.AcceptTcpClient();
                if (temp.Connected)
                {
                    tcpClients.Add(temp);
                    form.ADD_TO_LOG("Client " + temp.Client.RemoteEndPoint + " is joined");
                    connectionThread = new Thread(Client_Listening);
                    connectionThread.IsBackground = true;
                    connectionThread.Start(temp);
                }
            }
        }
        private void Client_Listening(object clientObj)
        {
            TcpClient listeningSoc = (TcpClient)clientObj;
            NetworkStream networkStream = listeningSoc.GetStream(); 
            //listeningSoc.Blocking = false;
            //Thread listeningThread = client_thread;
            while (true)
            {
                try
                {
                    if (networkStream.CanRead)
                    {
                        byte[] buffer = new byte[2048];
                        int BytesReaded = networkStream.Read(buffer);
                        if (BytesReaded <= 0)
                        {
                            form.ADD_TO_LOG("Fail to Read");
                        }
                        else {
                            form.ADD_TO_LOG("S");
                            string Message_From_Client = Encoding.UTF8.GetString(buffer, 0, BytesReaded);
                            form.ADD_TO_Recv("Sucessfully Receive " + Message_From_Client + " Form Client");
                        }
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
                catch(Exception ex)
                {
                    form.ADD_TO_LOG("Error : " + ex.Message);
                }
            }
        }

        
    }
}
