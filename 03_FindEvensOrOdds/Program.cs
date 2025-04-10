namespace Namespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Predicate<int> evensOrOdds = x =>
            {
                return x % 2 == 0;
            };

            Func<(string[], string), List<int>> nums = x =>
            {
                List<int> result = new();

                int startNum = int.Parse(x.Item1[0]);
                int endNum = int.Parse(x.Item1[1]);

                for (int i = startNum; i < endNum; i++)
                {
                    if (evensOrOdds(i) && x.Item2 == "even")
                    {
                        result.Add(i);
                    }
                    else if (!evensOrOdds(i) && x.Item2 == "odd")
                    {
                        result.Add(i);
                    }
                }

                return result;
            };

            string[] input = Console.ReadLine().Split(" ");
            string type = Console.ReadLine();

            List<int> result = nums((input, type));

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}