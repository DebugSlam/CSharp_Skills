SortedDictionary<int, int> numberHowManyTimer = new();

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in input)
{
    if (numberHowManyTimer.ContainsKey(number))
    {
        numberHowManyTimer[number]++;

    }

    else
    {
        numberHowManyTimer.Add(number, 1);
    }
}

//foreach (KeyValuePair<char, int> pair in characters)
//{
//    Console.WriteLine($"{pair.Key} -> {pair.Value}");
//}


foreach (var pair in numberHowManyTimer)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}