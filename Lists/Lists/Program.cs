
string inputLine = Console.ReadLine();

    string[] withoutSpaces = inputLine.Split(' ');

    List<int> numbers = new List<int>();

foreach (string num in withoutSpaces)
    {
        if (int.TryParse(num, out int parsedNum))
        {
            numbers.Add(parsedNum);

        }
    }


string command = Console.ReadLine();


while (command != "end")

{
 
    
        string[] commandParts = command.Split(" ");
        string commandName = commandParts[0];
    int element1 = int.Parse(commandParts[1]);

    if (commandName == "Delete")
    {
       numbers.RemoveAll(item => item ==  element1);
    }

    else if (commandName == "Insert")
    {
        int element2 = int.Parse(commandParts[2]);

        numbers.Insert(element2, element1);

    }

    command = Console.ReadLine();

}


for (int i = 0; i <= numbers.Count - 1; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();