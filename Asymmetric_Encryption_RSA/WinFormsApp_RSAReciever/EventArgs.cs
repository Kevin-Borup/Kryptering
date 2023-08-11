using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSAReciever
{
    public class ServerTextEventArgs
    {
        public ServerTextEventArgs(byte[] bytes = null) { Bytes = bytes; }
        public byte[] Bytes { get; private set; }
    }

    public class EncryptorTextEventArgs
    {
        public EncryptorTextEventArgs(string text, byte[] bytes) { Text = text; Bytes = bytes; }
        public string Text { get; private set; }
        public byte[] Bytes { get; private set; }
    }
}
