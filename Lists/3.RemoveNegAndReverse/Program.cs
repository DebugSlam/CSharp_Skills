List<int> numbers = RowNumbersSpaces();


for (int i = 0; i <= numbers.Count - 1; i++)
{
    if (numbers[i] < 0)

    {
        numbers.Remove(numbers[i]);

        i--;

    }
}


static List<int> RowNumbersSpaces()
{
    string inputLine = Console.ReadLine();

    string[] withoutSpaces = inputLine.Split(' ');

    List<int> numbers = new List<int>();

    foreach (string num in withoutSpaces)
    {
        if (int.TryParse(num, out int parsedNum))
        {
            numbers.Add(parsedNum);

        }
    }

    return numbers;
}

numbers.Reverse();
if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}

else
{ 
foreach (var num in numbers)
{
    Console.Write(num + " ");

}
Console.WriteLine();
}