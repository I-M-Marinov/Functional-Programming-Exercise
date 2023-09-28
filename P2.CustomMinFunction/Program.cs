Action<string[]> printNamesWithAddedTitle = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle(inputNames);