using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientAPP
{
    public class ClientControl
    {
        private Socket clientSocket;

        string msgrec;

        public ClientControl()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public int Connect(string ip, int port)
        {
            try
            {
                clientSocket.Connect(ip, port);
            }
            catch
            {
                return 1;
            }
            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start();
            return 0;
        }

        public void Receive()
        {
            byte[] msg = new byte[1024 * 1024];
            int msgLen = clientSocket.Receive(msg);
            msgrec = Encoding.UTF8.GetString(msg, 0, msgLen);

            Receive();
        }

        public string Received()
        {
            return msgrec;
        }

       

        public void Send(string msg)
        {
            clientSocket.Send(Encoding.UTF8.GetBytes(msg));
        }
    }
}
