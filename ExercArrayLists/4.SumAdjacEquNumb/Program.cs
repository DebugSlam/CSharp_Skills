List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


List<int> result = new List<int>();


for (int i = 0; i < numbers.Count-1; i++)
{

    if (numbers[i] == numbers[i + 1])
    {
        int res = numbers[i] + numbers[i + 1];

        numbers.RemoveAt(i);

        numbers.RemoveAt(i);

        numbers.Insert(i, res);

        i = -1;
    }
  
}


foreach (int digit in numbers)
{
    Console.Write(digit + " ");
}
Console.WriteLine();