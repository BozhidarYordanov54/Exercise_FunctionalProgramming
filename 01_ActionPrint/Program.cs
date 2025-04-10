namespace ActionPrint
{
    public class Program
    {
        private static Action<string[]> printNames = x =>
        {
            foreach (string item in x)
            {
                Console.WriteLine($"{item}");
            }
        };

        public static void Main(string[] args)
        {
            string[] dataInput = Console.ReadLine()
                                .Split(" ")
                                .ToArray();

            printNames(dataInput);
        }
    }
}

