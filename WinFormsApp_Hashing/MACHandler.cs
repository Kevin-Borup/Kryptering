using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Hashing
{
    internal class MACHandler
    {
        private HMAC thisMac;
        public HMAC MAC
        {
            get
            {
                return thisMac;
            }
        }

        public MACHandler(string encryption, byte[] key)
        {
            switch (encryption)
            {
                case "MD5":
                    thisMac = new HMACMD5(key);
                    break;
                //case "RIPEMD":
                //    mac = new HMA();
                //    break;
                case "SHA1":
                    thisMac = new HMACSHA1(key);
                    break;
                case "SHA256":
                    thisMac = new HMACSHA256(key);
                    break;
                case "SHA384":
                    thisMac = new HMACSHA384(key);
                    break;
                case "SHA512":
                    thisMac = new HMACSHA512(key);
                    break;
            }
        }

        public bool CheckAuthenticity(byte[] mes, byte[] mac, byte[] key)
        {
            return CompareByteArrays(ComputeMAC(mes, key), mac, ByteLength());
        }

        public byte[] GetMAC()
        {
            return thisMac.Key;
        }

        public byte[] ComputeMAC(byte[] mes, byte[] key)
        {
            thisMac.Key = key;
            return thisMac.ComputeHash(mes);
        }

        public int ByteLength()
        {
            return thisMac.HashSize / 8;
        }

        private bool CompareByteArrays(byte[] a, byte[] b, int len)
        {
            for (int i = 0; i < len; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
    }
}
