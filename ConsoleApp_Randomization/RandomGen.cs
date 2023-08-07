using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp_Randomization
{
    internal class RandomGen
    {
        public RandomGen()
        {

        }

        public int[] Random()
        {
            Random rnd = new Random();

            int[] randomNums = new int[100];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(0, 999);
            }

            return randomNums;
        }

        

        public int[] RandomNumGen()
        {
            var rndNumGen = RandomNumberGenerator.Create();
            int[] randomNums = new int[100];

            for (int i = 0; i < randomNums.Length; i++)
            {
                byte[] randomBytes = new byte[4];
                rndNumGen.GetBytes(randomBytes);
                randomNums[i] = BitConverter.ToInt32(randomBytes, 0) % 1000;
            }

            return randomNums;
        }

        public void RandomTest()
        {
            Random rnd = new Random();

            int[] randomNums = new int[1000000];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(0, 999);
            }
        }

        public void RandomNumGenTest()
        {
            var rndNumGen = RandomNumberGenerator.Create();
            int[] randomNums = new int[1000000];

            for (int i = 0; i < randomNums.Length; i++)
            {
                byte[] randomBytes = new byte[4];
                rndNumGen.GetBytes(randomBytes);
                randomNums[i] = BitConverter.ToInt32(randomBytes, 0);
            }
        }

        public string SubstitutionEncrypt(string outputTxt)
        {
            char[] chars = outputTxt.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] * 2);
            }

            return new string(chars);
        }

        public string SubstitutionDecrypt(string inputTxt)
        {
            char[] chars = inputTxt.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] / 2);
            }

            return new string(chars);
        }


    }
}

