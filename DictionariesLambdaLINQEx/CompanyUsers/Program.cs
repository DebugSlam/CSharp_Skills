using System.Diagnostics;

Dictionary<string, List<string>> companyAndID = new();

string input = Console.ReadLine();


while (input != "End")

{
    string[] inputArray = input.Split("->").ToArray();

    string name = inputArray[0];

    string id = inputArray[1];


    if (companyAndID.ContainsKey(name))
    {
        
        if (!companyAndID[name].Any())
        {
            // If the list is empty, add the new id directly
            companyAndID[name].Add(id);
        }
        else if (!companyAndID[name].Contains(id))
        {
            companyAndID[name].Add(id);
        }

    }

    else
    {
        companyAndID.Add(name, new List<string> { id });

    }

    input = Console.ReadLine();

}

foreach (var pair in companyAndID)
{

    Console.WriteLine($"{pair.Key}");

    foreach (var value in pair.Value)
    {
        Console.WriteLine($"--{value}");
    }
}
