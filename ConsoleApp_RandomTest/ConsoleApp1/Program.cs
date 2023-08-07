namespace ConsoleApp1
{
    using System.Security.Cryptography;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            Exercise2();

        }

        static void Exercise1()
        {
            Random rnd = new Random();

            for (int ctr = 0; ctr < 10; ctr++)
            {
                Console.Write("{0,3}    ", rnd.Next(-10, 11));
            }
        }

        static void Exercise2()
        {
            var randomNumberGenerator = RandomNumberGenerator.Create();
            // Antal bytes afhænger af datatypen (her bruger vi 4 bytes til et int)
            byte[] randomBytes = new byte[4];
            randomNumberGenerator.GetBytes(randomBytes);
            // Konverterer byte-arrayet til en int
            int randomNumber = BitConverter.ToInt32(randomBytes, 0);
        }
    }
}