List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")

{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];
    int element = int.Parse(commandParts[1]);

    if (commandName == "Remove")
    {
        numbers.RemoveAll(item => item == element);
    }
    else if (commandName == "Add")
    {
        numbers.Add(element);
    }
    else if (commandName == "Insert")
    {
        int index = int.Parse(commandParts[2]);

        numbers.Insert(index, element);

    }

    else if (commandName == "RemoveAt")
    {
        numbers.RemoveAt(element);

    }

    command = Console.ReadLine();

}

foreach (var num in numbers)
{
    Console.Write(num + " ");

}
Console.WriteLine();

