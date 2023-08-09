using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_SymmetricEncryption
{
    public enum Encryption
    {
        DES,
        TDES,
        AES,
        AesGcm
    }

    internal class Encryptor
    {
        public Dictionary<string, Encryption> EncryptionTypes = new Dictionary<string, Encryption> 
        {
            { "DES",        Encryption.DES },
            { "Triple DES", Encryption.TDES },
            { "AES",        Encryption.AES },
            { "AesGcm",     Encryption.AesGcm }
        };

        private byte[] key, iv, tag;
        private Encryption encryptionType;

        /// <summary>
        /// Encrypts the provided text with the current encryption algorithm.
        /// The encrypted text is returned in its string form.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string EncryptText(string text)
        {
            string encryptedText = string.Empty;

            if (!string.IsNullOrWhiteSpace(text))
            {
                byte[] bytedText = Encoding.UTF8.GetBytes(text);
                byte[] encryptedData = TranscipherAlgo(bytedText, true);

                if (encryptedData == null)
                {
                    encryptedText = string.Empty;
                }
                else
                {
                    encryptedText = Convert.ToBase64String(encryptedData);
                }
            }

            return encryptedText;
        }

        /// <summary>
        /// Decrypts the provided text with the current encryption algorithm.
        /// The decrypted text is returned in its string form.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string DecryptText(string text)
        {
            string decryptedText = string.Empty;

            if (!string.IsNullOrWhiteSpace(text))
            {
                byte[] bytedText = Convert.FromBase64String(text);
                byte[] decryptedData = TranscipherAlgo(bytedText, false);

                if (decryptedData == null)
                {
                    decryptedText = string.Empty;
                }
                else
                {
                    decryptedText = Encoding.UTF8.GetString(decryptedData);
                }
            }

            return decryptedText;
        }

        /// <summary>
        /// The generalized transciphering algorithm.
        /// It encrypts and decrypts the data, with the currently active encryption.
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        private byte[] TranscipherAlgo(byte[] data, bool encrypt)
        {
            byte[] encryptedData = null;
            // DES, TDES and AES uses the same parent class, and executes with the same commands.
            // The method can therefore be normalized around this on object.
            SymmetricAlgorithm encryption = null;

            try
            {
                switch (encryptionType)
                {
                    case Encryption.DES:
                        encryption = DES.Create();
                        break;
                    case Encryption.TDES:
                        encryption = TripleDES.Create();
                        break;
                    case Encryption.AES:
                        encryption = Aes.Create();
                        break;
                    case Encryption.AesGcm:
                        // AesGcm doesn't inherit the SymmetricAlgorithm, and therefore has a different procedure.
                        return AesGcmEncryption(data, encrypt);
                }

                if (encryption is not null)
                {
                    encryption.Mode = CipherMode.CBC;
                    encryption.Padding = PaddingMode.PKCS7;

                    encryption.Key = key;
                    encryption.IV = iv;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Defines whether we are encrypting or decrypting the data.
                        var createdAction = encrypt ? encryption.CreateEncryptor() : encryption.CreateDecryptor();
                        using (var cryptoStream = new CryptoStream(ms, createdAction, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(data, 0, data.Length);
                            // The cryptostream is flushed, so the encryption process can't be found in the decices RAM.
                            cryptoStream.FlushFinalBlock();
                        }
                        encryptedData = ms.ToArray();
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                // All ressources are disposed, equivelant to implementing a using scope.
                // The object is disposed even on exceptions.
                if (encryption != null) { encryption.Dispose(); }
            }

            return encryptedData;
        }

        /// <summary>
        /// Encrypts or Decrycpts the data with AesGcm algorithm.
        /// </summary>
        /// <param name="dataToEncrypt"></param>
        /// <param name="encrypt"></param>
        /// <returns></returns>
        private byte[] AesGcmEncryption(byte[] dataToEncrypt, bool encrypt)
        {
            byte[] cipherText = new byte[dataToEncrypt.Length];

            try
            {
                var aesGcm = new AesGcm(key);
                byte[] nonce = iv;

                if (encrypt)
                {
                    tag = new byte[AesGcm.TagByteSizes.MaxSize];
                    aesGcm.Encrypt(nonce, dataToEncrypt, cipherText, tag);
                }
                else
                {
                    aesGcm.Decrypt(nonce, dataToEncrypt, tag, cipherText);
                }
            }
            catch (Exception)
            {
                cipherText = null;
            }

            return cipherText;
        }

        /// <summary>
        /// Generates the Key and IV of the encryption type.
        /// AesGcm generates Nonce in the space of IV.
        /// </summary>
        /// <param name="encryptType"></param>
        /// <returns></returns>
        public (byte[] Key, byte[] IV) GetKeyAndIV(Encryption encryptType)
        {
            (byte[] Key, byte[] IV) encryptDets;

            switch (encryptType)
            {
                case Encryption.DES:
                    encryptDets.Key = GenerateRandomByteArray(8);
                    encryptDets.IV = GenerateRandomByteArray(8);
                    break;
                case Encryption.TDES:
                    encryptDets.Key = GenerateRandomByteArray(16);
                    encryptDets.IV = GenerateRandomByteArray(8);
                    break;
                case Encryption.AES:
                    encryptDets.Key = GenerateRandomByteArray(32);
                    encryptDets.IV = GenerateRandomByteArray(16);
                    break;
                case Encryption.AesGcm:
                    encryptDets.Key = GenerateRandomByteArray(32);
                    encryptDets.IV = GenerateRandomByteArray(AesGcm.NonceByteSizes.MaxSize);
                    break;
                default:
                    encryptDets.Key = new byte[0];
                    encryptDets.IV = new byte[0];
                    break;
            }

            this.key = encryptDets.Key;
            this.iv = encryptDets.IV;
            this.encryptionType = encryptType;

            return encryptDets;
        }

        /// <summary>
        /// Generates a randomized byte array of the provided length.
        /// </summary>
        /// <param name="byteLength"></param>
        /// <returns></returns>
        private byte[] GenerateRandomByteArray(int byteLength)
        {
            byte[] bytes = new byte[byteLength];
            RandomNumberGenerator.Fill(bytes);

            return bytes;
        }

        /// <summary>
        /// Converts the text to Hex value, and removes dashes.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ConvertToHEX(string text)
        {
            return BitConverter.ToString(Encoding.Default.GetBytes(text)).Replace("-", "");
        }
    }
}
