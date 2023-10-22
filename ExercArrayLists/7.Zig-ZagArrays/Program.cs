List<int> numbers1 = new List<int>();

List<int> numbers2 = new List<int>();


int stopNumber = int.Parse(Console.ReadLine());

int i = 1;

while (i <= stopNumber)

{
    List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

    if (i % 2 != 0)
    {

        numbers1.Add(numbers[0]);

        numbers2.Add(numbers[1]);
    }

    else
    {

        numbers2.Add(numbers[0]);

        numbers1.Add(numbers[1]);
    }
    i++;
}

Console.WriteLine(String.Join(" ",numbers1));

Console.WriteLine(String.Join(" ", numbers2));

