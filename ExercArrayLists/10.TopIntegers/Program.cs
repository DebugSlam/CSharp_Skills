List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int endCheck = numbers.Count - 1;

for (int i = 0; i <= endCheck; i++)

{
    int cnt = i;

    while (cnt + 1 <= endCheck)
    {
        if (numbers[i] > numbers[cnt + 1])
        {
            if (cnt == endCheck-1)

            {
                Console.Write(numbers[i] + " ");
            }

            cnt++;
        }

        else
        {
            break;
        }
    }

    if (i==endCheck)
    {
       Console.Write(numbers[i] + " ");

    }
}

Console.WriteLine();

