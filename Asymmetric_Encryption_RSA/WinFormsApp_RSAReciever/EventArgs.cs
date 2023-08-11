using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSAReciever
{
    /// <summary>
    /// Contains the bytes recieved from the socket.
    /// </summary>
    public class ServerTextEventArgs
    {
        public ServerTextEventArgs(byte[] bytes = null) { Bytes = bytes; }
        public byte[] Bytes { get; private set; }
    }

    /// <summary>
    /// Contains the recieved bytes and the decrypted text.
    /// </summary>
    public class EncryptorTextEventArgs
    {
        public EncryptorTextEventArgs(string text, byte[] bytes) { Text = text; Bytes = bytes; }
        public string Text { get; private set; }
        public byte[] Bytes { get; private set; }
    }
}
