Action<string, string[]> printNamesWithAddedTitle = (title, names) =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};

string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle("Sir", inputNames);