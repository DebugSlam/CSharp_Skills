string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new();

foreach (string word in words)

    {

    string caseInsensitive = word.ToLower();


    if (wordsCount.ContainsKey(caseInsensitive))
    {
        wordsCount[caseInsensitive]++;

    }

    else
    {
        wordsCount.Add(caseInsensitive, 1);
    }
}

foreach (KeyValuePair<string, int> pair in wordsCount)
{

    if(pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}
Console.WriteLine();