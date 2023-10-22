//List<int> numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//List<int> numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

//List<int> result = new List<int>();

//List<int> bigger = new List<int>();

//List<int> smaller = new List<int>();

//if (numbers1.Count == numbers2.Count)
//{
//    for (int i = 0; i < smaller.Count; i++)
//    {
//        result.Add(numbers1[i]);

//        result.Add(numbers2[i]);

//    }

//}

//else
//{

//    if (numbers1.Count < numbers2.Count)

//    {
//        bigger = numbers2;

//        smaller = numbers1;
//    }


//    else if (numbers1.Count > numbers2.Count)

//    {
//        bigger = numbers1;

//        smaller = numbers2;
//    }


//    result = CombeinTwoLists(numbers1, numbers2, smaller);


//    for (int i = smaller.Count + 1; i <= bigger.Count; i++)
//    {
//            result.Add(bigger[i]);

//    }

//}

//foreach (int digit in result)
//    {

//    Console.Write(digit + " ");
//}
//Console.WriteLine();

//static List<int> CombeinTwoLists(List<int> numbers1, List<int> numbers2, List<int> smaller)
//{
//    List<int> result = new List<int>();
//    for (int i = 0; i < smaller.Count; i++)
//    {
//        result.Add(numbers1[i]);

//        result.Add(numbers2[i]);

//    }

//    return result;
//}


List<int> numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> result = new List<int>();

int minLength = Math.Min(numbers1.Count, numbers2.Count);

for (int i = 0; i < minLength; i++)
{
    result.Add(numbers1[i]);
    result.Add(numbers2[i]);
}

for (int i = minLength; i < numbers1.Count; i++)
{
    result.Add(numbers1[i]);
}

for (int i = minLength; i < numbers2.Count; i++)
{
    result.Add(numbers2[i]);
}

foreach (int digit in result)
{
    Console.Write(digit + " ");
}
Console.WriteLine();