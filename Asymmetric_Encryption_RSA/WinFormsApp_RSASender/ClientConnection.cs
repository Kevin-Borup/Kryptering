﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Net.Sockets;
using System.Net;
using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace WinFormsApp_RSASender
{
    internal class ClientConnection
    {
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        Socket client;

        public ClientConnection()
        {
            IPEndPoint endPoint = new IPEndPoint(ip, 14);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ConnectClient();
        }

        /// <summary>
        /// Connect the client to the server
        /// </summary>
        private void ConnectClient()
        {
            client.Connect(ip, 13);
        }

        /// <summary>
        /// Recieve the public key from the socket connection to the server.
        /// Retries until achieved.
        /// </summary>
        /// <returns></returns>
        public byte[] GetPublicKey()
        {
            while (true)
            {
                if (client != null)
                {
                    if (client.ReceiveBufferSize > 0)
                    {
                        byte[] buffer = new byte[1024];
                        client.Receive(buffer);
                        return buffer;
                    }
                    else if (!client.Connected)
                    {
                        ConnectClient();
                    }
                }
            }
        }

        /// <summary>
        /// Sends the recieved bytes over the Socket client
        /// </summary>
        /// <param name="bytes"></param>
        public void SendMsg(byte[] bytes)
        {
            if (client != null && client.Connected)
            {
                client.Send(bytes);
            }
        }
    }
}