using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.Security.Policy;

namespace WinFormsApp_RSAReciever
{
    internal class ServerConnection
    {
        private Socket server;
        private Socket client;

        public delegate void ServerTextEventHandler(object sender, ServerTextEventArgs e);

        public event ServerTextEventHandler ServerTextEvent;

        public ServerConnection(byte[] publicKey)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint endPoint = new IPEndPoint(ip, 13);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endPoint);

            ConnectToClient();

            WriteKey(publicKey);
        }

        private void ConnectToClient()
        {
            server.Listen(100);
            client = server.Accept();
        }

        /// <summary>
        /// Broadcast the public key to the new connection.
        /// </summary>
        /// <param name="publicKey"></param>
        private void WriteKey(byte[] publicKey)
        {
            client.Send(publicKey, 0);
        }

        /// <summary>
        /// Constant while-loop, to repeatedly listen for messages.
        /// Reconnects if the connection is lost.
        /// </summary>
        public void StartRecieving()
        {
            try
            {
                while (true)
                {
                    if (client.Connected)
                    {
                        // Create a byte array the size of the incoming data and fill it with that data.
                        byte[] buff = new byte[client.Available];
                        while (client.Receive(buff) > 0)
                        {
                            //Fires the event with the recieved data, for it to be handled and transfered to the UI.
                            TextRecieved(buff);
                        }
                    }
                    else
                    {
                        client.Listen(0);
                        client = client.Accept();
                    }
                }
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        /// <summary>
        /// Invokes an event, when a new message has been recieved.
        /// </summary>
        /// <param name="bytes"></param>
        public void TextRecieved(byte[] bytes = null)
        {
            ServerTextEvent?.Invoke(this, new ServerTextEventArgs(bytes));
        }
    }
}
