namespace ConsoleApp_Randomization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGen rGen = new RandomGen();

            //Øvelse: Tilfældighedstest med Random og RandomNumberGenerator
            int[] randomOld = rGen.Random();
            int[] randomNew = rGen.RandomNumGen();

            //Øvelse: Benchmarking af Random og RandomNumberGenerator
            //RunBenchmark(rGen.RandomTest);
            //RunBenchmark(rGen.RandomNumGenTest);

            //Substitution kryptering
            string txt = "Hello World";

            string encrypted = rGen.SubstitutionEncrypt(txt);
            string decrypted = rGen.SubstitutionDecrypt(encrypted);

            Console.WriteLine($"Original: {txt} | Encrypted: {encrypted} | Decrypted: {decrypted}");

        }

        private static void RunBenchmark(Action benchmarkMethod)
        {
            double startTimeNew = DateTime.Now.Ticks;
            benchmarkMethod();
            double endTimeNew = DateTime.Now.Ticks;
            double elapsedTime = endTimeNew - startTimeNew;
            Console.WriteLine($"{benchmarkMethod.Method.Name} - tid (ticks): {elapsedTime}");
        }
    }
}