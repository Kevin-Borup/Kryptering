﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_RSASender
{
    internal class Encryptor
    {
        byte[] publicKey;
        private ClientConnection server;

        /// <summary>
        /// The RSA key is generated from the public key xml.
        /// Returns a tuple of public data, Expon
        /// </summary
        /// >
        /// <returns></returns>
        public (string Exponent, string Modulus) GetPublicData()
        {
            (string Exponent, string Modulus) publicData;

            using var rsa = RSA.Create();
            rsa.KeySize = 2048;

            server = new ClientConnection();

            rsa.ImportRSAPublicKey(server.GetPublicKey(), out _);

            publicKey = rsa.ExportRSAPublicKey();

            var rsaPara = rsa.ExportParameters(false);

            publicData.Exponent = BitConverter.ToString(rsaPara.Exponent);
            publicData.Modulus = BitConverter.ToString(rsaPara.Modulus);

            return publicData;
        }

        /// <summary>
        /// Send the recieved string to the server connection
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public byte[] SendText(string text)
        {
            byte[] encryptedData = EncryptText(text);

            server.SendMsg(encryptedData);

            return encryptedData;
        }

        /// <summary>
        /// The Sender encrypts the text, using the public key generated by the reciever.
        /// Immediatedly sends the message and sends the encrypted bytes back.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public byte[] EncryptText(string text)
        {
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(text);

            using (var rsa = RSA.Create())
            {
                rsa.ImportRSAPublicKey(publicKey, out _);

                byte[] encryptedData = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);
                return encryptedData;
            }
        }
    }
}
