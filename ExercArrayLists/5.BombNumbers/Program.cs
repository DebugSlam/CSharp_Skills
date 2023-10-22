List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string[] special = Console.ReadLine().Split(" ").ToArray();

int bombNumber = int.Parse(special[0]);


int bombPower = int.Parse(special[1]);

while (numbers.Contains(bombNumber))

{
    int indexBomb = numbers.IndexOf(bombNumber);

    int startIndexRemove = indexBomb - bombPower;
    int countToRemove = (indexBomb + bombPower + 1) - startIndexRemove;

    if (startIndexRemove < 0)
    {
        startIndexRemove = 0;
    }

    if (startIndexRemove + countToRemove > numbers.Count)
    {

        countToRemove = numbers.Count - startIndexRemove;
    }

    numbers.RemoveRange(startIndexRemove, countToRemove);
}

Console.WriteLine(numbers.Sum());
