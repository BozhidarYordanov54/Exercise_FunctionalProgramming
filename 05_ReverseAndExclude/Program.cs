
Predicate<int, int> isDividible = x => {
    return x.Item1 % x.Item2 == 0;
};

Func<(List<int>, int), List<int>> subrtract = x =>
{
    for (int i = 0; i < x.Item1.Count; i++)
    {
        if(isDividible(i, x.Item2))
        {
            x.Item1.Remove(i);
        }
    }
    return x.Item1;
};


Action<List<int>> Print = x =>
{
    Console.WriteLine($"{string.Join(" ", x)}");
};

List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Reverse()
                .ToList();