Dictionary<string, int> resources = new();

string input1 = Console.ReadLine();
int input2 = 0;
while (input1 != "stop")
{ 
 
    input2 = int.Parse(Console.ReadLine());


    if (resources.ContainsKey(input1))
        {
            resources[input1] += input2;
            
        }
        else
        {
            resources.Add(input1, input2);
        }

    input1 = Console.ReadLine();
}


foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}