using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSAReciever
{
    internal class Encryptor
    {
        private FileManager filer = new FileManager();

        byte[] privateKey;

        public Encryptor()
        {
            using var rsa = RSA.Create();
            rsa.KeySize = 2048;

            //Save the private key and print the publi


            privateKey = rsa.ExportRSAPrivateKey();
            filer.PrintPublicKey(rsa.ToXmlString(false));
        }

        /// <summary>
        /// Get all of the Parameter values of the private and public key.
        /// </summary>
        /// <returns></returns>
        public string[] GetRSAParameters()
        {
            string[] parameters = new string[8];

            //Recreate the RSA key with the private key value
            using var rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(privateKey, out _);
            var rsaPara = rsa.ExportParameters(true);

            parameters[0] = BitConverter.ToString(rsaPara.Exponent);
            parameters[1] = BitConverter.ToString(rsaPara.Modulus);
            parameters[2] = BitConverter.ToString(rsaPara.D);
            parameters[3] = BitConverter.ToString(rsaPara.DP);
            parameters[4] = BitConverter.ToString(rsaPara.DQ);
            parameters[5] = BitConverter.ToString(rsaPara.InverseQ);
            parameters[6] = BitConverter.ToString(rsaPara.P);
            parameters[7] = BitConverter.ToString(rsaPara.Q);

            return parameters;
        }

        /// <summary>
        /// Get the recieved bytes from the sender
        /// </summary>
        /// <returns></returns>
        internal byte[] GetCipherBytes()
        {
            byte[] bytes = filer.GetRecievedBytes();

            return bytes;
        }
        
        /// <summary>
        /// Decrypt the encrypted bytes, with the stored private key.
        /// </summary>
        /// <param name="cipherBytes"></param>
        /// <returns></returns>
        internal string DecryptBytes(byte[] cipherBytes)
        {
            using (var rsa = RSA.Create())
            {
                // Uses the private key to create a RSA, that is able to decrypt the text.
                rsa.ImportRSAPrivateKey(privateKey, out _);
                byte[] decryptedBytes = rsa.Decrypt(cipherBytes, RSAEncryptionPadding.Pkcs1);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
