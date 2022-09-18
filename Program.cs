#region FirstTask

var firstString = Console.ReadLine();
var secondString = Console.ReadLine();

var isAnagram = IsAnagram();
Console.WriteLine(isAnagram ? "yes" : "no");

bool IsAnagram()
{
    if (firstString == null || secondString == null)
    {
        return false;
    }

    var firstFrequencyDictionary = CreateDictionary(firstString);
    var secondFrequencyDictionary = CreateDictionary(secondString);

    foreach (var key in firstFrequencyDictionary.Keys)
    {
        if (!secondFrequencyDictionary.TryGetValue(key, out var value)
            && value != firstFrequencyDictionary[key])
        {
            return false;
        }
    }

    return true;
}

Dictionary<char, int> CreateDictionary(string str)
{
    var result = new Dictionary<char, int>();
    
    foreach (var symbol in str)
    {
        if (result.ContainsKey(symbol))
        {
            result[symbol] += 1;
            continue;
        }
        
        result.Add(symbol, 1);
    }

    return result;
}

#endregion

#region SecondTask

var arr = Console.ReadLine()?.Split(" ").Select(int.Parse).ToArray();

if (arr == null || arr.Length == 0)
{
    throw new Exception("Array is null or empty");
}

var max = arr.Max();
var min = arr.Min();
var minMaxArr = new int[2] {min, max};

Console.WriteLine($"Min: {minMaxArr[0]} \nMax: {minMaxArr[1]}");

#endregion