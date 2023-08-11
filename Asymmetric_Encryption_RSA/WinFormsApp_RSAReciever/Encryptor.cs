using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_RSAReciever
{
    internal class Encryptor
    {
        private ServerConnection server;

        byte[] privateKey;

        public delegate void EncryptorTextHandler(object sender, EncryptorTextEventArgs e);

        public event EncryptorTextHandler EncryptorTextHandledEvent;

        public Encryptor()
        {
            using var rsa = RSA.Create();
            rsa.KeySize = 2048;

            //Save the private key and print the public key
            privateKey = rsa.ExportRSAPrivateKey();
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
        /// Decrypt the encrypted bytes, with the stored private key.
        /// </summary>
        /// <param name="cipherBytes"></param>
        /// <returns></returns>
        internal string DecryptBytes(byte[] cipherBytes)
        {
            using (var rsa = RSA.Create())
            {
                try
                {
                    // Uses the private key to create a RSA, that is able to decrypt the text.
                    rsa.ImportRSAPrivateKey(privateKey, out _);
                    byte[] decryptedBytes = rsa.Decrypt(cipherBytes, RSAEncryptionPadding.Pkcs1);
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
                catch (Exception)
                {
                    //Would be written in a log
                    return string.Empty;
                }
                
            }
        }

        /// <summary>
        /// Setup the server and broadcast the public key
        /// Followed by listening for a new conenction.
        /// </summary>
        public void SetupServer()
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportRSAPrivateKey(privateKey, out _);
                server = new ServerConnection(rsa.ExportRSAPublicKey());
                server.ServerTextEvent += Server_ServerTextEvent;
                StartListening();
            }
        }

        private void StartListening()
        {
            Thread t1 = new Thread(server.StartRecieving);
            t1.Start();
        }

        private void Server_ServerTextEvent(object sender, ServerTextEventArgs e)
        {
            if (e != null && e.Bytes != null)
            {
                byte[] recievedBytes = e.Bytes;

                string decryptedText = DecryptBytes(recievedBytes);

                EncryptorTextHandledEvent?.Invoke(this, new EncryptorTextEventArgs(decryptedText, recievedBytes));
            }
        }
    }
}
