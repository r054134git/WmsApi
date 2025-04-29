using System.Net.Sockets;
using System.Net;
using System;

namespace ApiTracker
{
    public class ClientSocket
    {
        private Socket clientSocket;
        public ClientSocket()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        /// <summary>
        /// 连接服务器端
        /// </summary>
        public void ConnectToServer(String ip, int port)
        {
            clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
        }
        /// <summary>
        /// 向服务器端发送消息
        /// </summary>
        public void SendMSGToServer(byte[] msg)
        {
            clientSocket.Send(msg);
        }
    }
}
