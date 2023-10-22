List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


int sum = 0;

while (1 < numbers.Count)
{ 
    for (int n = 0; n < numbers.Count - 1; n++)
    {
        sum = numbers[n] + numbers[n+1];

    numbers[n] = sum;
    //Console.Write(sum + " ");
    }

    numbers.RemoveAt(numbers.Count - 1);
}
Console.WriteLine(numbers[0]);