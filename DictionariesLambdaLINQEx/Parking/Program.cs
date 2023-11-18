using System.Diagnostics;

Dictionary<string, string> ownerPlate = new();

int count = int.Parse(Console.ReadLine());


for (int i = 0; i < count; i++ )
{
    string[] input = Console.ReadLine().Split().ToArray();
    string command = input[0];
    string name = input[1];
    

    if (command == "register")
    {
        string plate = input[2];

        if (!ownerPlate.ContainsKey(name))
        {
            ownerPlate.Add(name, plate);
            Console.WriteLine($"{name} registered {ownerPlate[name]} successfully");
        }

        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {ownerPlate[name]}");

        }

    }

    else if(command == "unregister")
    {

        if (!ownerPlate.ContainsKey(name))
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }

        else
        { 
            ownerPlate.Remove(name);
        Console.WriteLine($"{name} unregistered successfully");
        }
    }

}

foreach (var pair in ownerPlate)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}