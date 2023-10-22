

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


int first = 0;
int last = numbers.Count-1;


int sum = 0;

for (int n = 0; (first+n) <= (last-n); n++)
{
    if ((first + n) == (last - n))
    {
        sum = numbers[first + n];
    }
    else
    {

        sum = numbers[first + n] + numbers[last - n];
    }
    Console.Write(sum + " ");
}

    Console.WriteLine();
