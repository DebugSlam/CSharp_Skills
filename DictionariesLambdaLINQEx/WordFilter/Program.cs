string[] input = Console.ReadLine().Split(" ").ToArray();

string[] result = input.Where(x => x.Length % 2 == 0).ToArray();

foreach(string word in result)
{
    Console.WriteLine(word);
}