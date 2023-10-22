List<int> numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();



for (int i = 0; i < numbers1.Count && i < numbers2.Count ; i++)



{
    
    if (numbers1[i] > numbers2[i])
    {
        numbers1.Add(numbers1[i]);
        numbers1.Add(numbers2[i]);

        numbers1.RemoveAt(i);
        numbers2.RemoveAt(i);
        i += -1;

    }


    else if (numbers1[i] < numbers2[i])
    {
        numbers2.Add(numbers2[i]);
        numbers2.Add(numbers1[i]);
        
        numbers1.RemoveAt(i);
        numbers2.RemoveAt(i);
        i += -1;
    }

    else
    {
        numbers1.RemoveAt(i);
        numbers2.RemoveAt(i);
        i += -1;

    }


}


if (numbers1.Sum() > numbers2.Sum())
{ 
Console.WriteLine($"First player wins! Sum: {numbers1.Sum()}");
}
if (numbers1.Sum() < numbers2.Sum())
{
    Console.WriteLine($"Second player wins! Sum: {numbers2.Sum()}");
}

