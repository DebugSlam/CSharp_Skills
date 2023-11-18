
Dictionary<string, List<string>> synonims = new();

int numPairs = int.Parse(Console.ReadLine());


for (int i =0; i <  numPairs; i++)
{
    string word = Console.ReadLine();

    string synonim = Console.ReadLine();

    if (synonims.ContainsKey(word))
        {
        synonims[word].Add(synonim);
        }
    else
    {
        synonims.Add(word, new List<string> { synonim });
    }

}


    foreach (KeyValuePair<string, List<string>> pair in synonims)
{

    
        Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
    
}