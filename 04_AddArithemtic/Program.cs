using System.Reflection.Metadata.Ecma335;

Func<int[], int[]> Add = x =>
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i]++;
    }
    return x;
};
Func<int[], int[]> Multiply = x =>
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] *= 2;
    }
    return x;
};
Func<int[], int[]> subrtract = x =>
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i]--;
    }
    return x;
};

Action<int[]> Print= x => 
{
    Console.WriteLine($"{string.Join(" ", x) }");
};

string cmd = string.Empty;
int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

while((cmd = Console.ReadLine()) != "end")
{
    switch(cmd)
    {
        case "add":
            Add(nums);
            break;

        case "multiply":
            Multiply(nums);
            break;

        case "subtract":
            subrtract(nums);
            break;

        case "print":
            Print(nums);
            break;
    }
}