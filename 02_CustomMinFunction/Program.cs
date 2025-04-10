Func<List<int>, int> minNumUsingMethod = x =>
{
    return x.Min();
};

Func<List<int>, int> minNum = x =>
{
    int minNum = int.MaxValue;

    foreach(int num in x)
    {
        if(num < minNum)
        {
            minNum = num;
        }
    }

    return minNum;
};


List<int> dataInput = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

Console.WriteLine($"{ minNum(dataInput) }");
Console.WriteLine($"Second method");
Console.WriteLine($"{ minNumUsingMethod(dataInput) }");