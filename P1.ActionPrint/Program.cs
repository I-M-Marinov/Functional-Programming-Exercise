Action<string[]> print = (string[] strings) =>
    Console.WriteLine(string.Join(Environment.NewLine, strings));

string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(strings);