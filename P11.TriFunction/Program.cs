Func<string, int, bool> checkEqualOrLargerNameSum = (name, sum) =>
{
    int charSum = name.Sum(ch => ch);
    return charSum >= sum;
};

Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
    names.FirstOrDefault(name => match(name, sum)); 

int sum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 

string foundName = getFirstName(names, sum, checkEqualOrLargerNameSum);

Console.WriteLine(foundName);