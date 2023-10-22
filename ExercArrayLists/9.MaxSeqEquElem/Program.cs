List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();



List<int> result = new List<int>();

int itEquals = 0;

for (int i = 0; i < numbers.Count - 1; i++)

{


    while (numbers[i] == numbers[i + 1])

    {
        itEquals += 1;
        i++;

        if (i + 1 == numbers.Count)
        { break; }

    }

    if (itEquals > result.Count - 1)
    {
        result = new List<int>();



        for (int cnt = i - itEquals; cnt <= i; cnt++)

        {

            result.Add(numbers[cnt]);

        }

    }

    itEquals = 0;

}

Console.WriteLine(String.Join(" ", result));

