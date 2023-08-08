using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_PasswordStorage
{
    internal class Encryptor
    {
        private int byteLength = 32;
        private int encryptionIterations = 5000;

        public void EncryptPassword(string password, out string pass, out string salt)
        {
            byte[] hashSalt = GenerateSalt();
            pass = Convert.ToBase64String(HashPassword(Encoding.UTF8.GetBytes(password), hashSalt, encryptionIterations));
            salt = Convert.ToBase64String(hashSalt);
        }

        public bool CheckPassword(string password, string pass, string salt)
        {
            bool equal = false;
            byte[] bytedPass = Convert.FromBase64String(pass);
            byte[] hashSalt = Convert.FromBase64String(salt);
            byte[] newPass = HashPassword(Encoding.UTF8.GetBytes(password), hashSalt, encryptionIterations);

            if (bytedPass.Length == newPass.Length)
            {
                equal = CompareByteArrays(bytedPass, newPass, newPass.Length);
            }

            return equal;
        }

        private bool CompareByteArrays(byte[] a, byte[] b, int len)
        {
            for (int i = 0; i < len; i++)
                if (a[i] != b[i]) return false;
            return true;
        }


        private byte[] GenerateSalt()
        {
            var randomNumberGenerator = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[byteLength]; // Antallet af bytes til saltet
            randomNumberGenerator.GetBytes(randomBytes);

            return randomBytes;
        }

        private byte[] HashPassword(byte[] toBeHashed, byte[] salt, int numberOfRounds)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(toBeHashed, salt, numberOfRounds, HashAlgorithmName.SHA512))
            {
                return rfc2898.GetBytes(byteLength);
            }
        }
    }
}


