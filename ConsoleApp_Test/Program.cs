namespace ConsoleApp_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testPass = "ThisIsAPassword";
            string base64 = Base64Encode(testPass);
            string fromBase64 = Base64Decode(base64);

            Console.WriteLine(testPass);
            Console.WriteLine(base64);
            Console.WriteLine(fromBase64);
        }

        public static string Base64Encode(string text)
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBytes);
        }
        public static string Base64Decode(string base64)
        {
            var base64Bytes = System.Convert.FromBase64String(base64);
            return System.Text.Encoding.UTF8.GetString(base64Bytes);
        }
    }
}