using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Hashing
{
    internal class Encryptor
    {
        private MACHandler macHandler;

        public string[] EncryptionTypes { get; private set; }

        public Encryptor()
        {
            EncryptionTypes = new string[] { "MD5", "SHA1", "SHA256", "SHA384", "SHA512" };
        }

        public void EncryptText(byte[] msg, out byte[] hashValue, out byte[] encryptedBytes)
        {
            using (HMAC hasher = macHandler.MAC)
            {
                using (MemoryStream ms = new MemoryStream(msg))
                {
                    using (CryptoStream cs = new CryptoStream(ms, hasher, CryptoStreamMode.Read)) 
                    {
                        cs.CopyTo(Stream.Null);
                    }
                }
                hashValue = hasher.Hash;
                encryptedBytes = hasher.ComputeHash(msg);
            }
        }

        public void CreateMAC(string encryptionType, byte[] key)
        {
            macHandler = new MACHandler(encryptionType, key);
        }

        public bool IsMACNull()
        {
            return macHandler == null;
        }

        public string GetMAC()
        {
            return BitConverter.ToString(macHandler.MAC.Key);
        }
    }
}
