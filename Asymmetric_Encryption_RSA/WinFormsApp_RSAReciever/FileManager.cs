using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSAReciever
{
    internal class FileManager
    {
        /// <summary>
        /// Writes the public key into an XML, the previous is deleted and replaced by the current one.
        /// </summary>
        /// <param name="publicKey"></param>
        public void PrintPublicKey(string publicKey)
        {
            string publicKeyXmlPath = "C:\\ZBC Data-Kommunikation\\H3\\Kryptering\\Asymmetric_Encryption_RSA\\publickey.xml";

            if (File.Exists(publicKeyXmlPath))
            {
                File.Delete(publicKeyXmlPath);
            }

            using (StreamWriter writer = new StreamWriter(publicKeyXmlPath))
            {
                writer.WriteLine(publicKey);
            }
        }

        /// <summary>
        /// If RSAmsg.txt is found, all of the text is read and converted from Base64.
        /// </summary>
        /// <returns></returns>
        public byte[] GetRecievedBytes()
        {
            string filePath = "C:\\ZBC Data-Kommunikation\\H3\\Kryptering\\Asymmetric_Encryption_RSA\\RSAmsg.txt";

            if (File.Exists(filePath))
            {
                return Convert.FromBase64String(File.ReadAllText(filePath));
            }

            return new byte[0];
        }
    }
}
