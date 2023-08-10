using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSASender
{
    internal class FileManager
    {
        /// <summary>
        /// Writes the byte in a Base64 string to a text file.
        /// </summary>
        /// <param name="msg"></param>
        public void PrintMsg(byte[] msg)
        {
            string filePath = "C:\\ZBC Data-Kommunikation\\H3\\Kryptering\\Asymmetric_Encryption_RSA\\RSAmsg.txt";

            if (File.Exists(filePath)) { File.Delete(filePath); }

            File.WriteAllBytes(filePath, msg);
        }

        /// <summary>
        /// Reads all the text found in the binary publickey.xml
        /// </summary>
        /// <returns></returns>
        public string GetXMLPublicData()
        {
            string publicKeyXmlPath = "C:\\ZBC Data-Kommunikation\\H3\\Kryptering\\Asymmetric_Encryption_RSA\\publickey.xml";



            if (File.Exists(publicKeyXmlPath))
            {
                byte[] publicBytes = File.ReadAllBytes(publicKeyXmlPath);

                return Encoding.UTF8.GetString(publicBytes);
            }

            return string.Empty;
        }
    }
}
