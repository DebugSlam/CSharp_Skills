List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")

{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];


    if (commandName == "Contains")
    {
        int element = int.Parse(commandParts[1]);
        bool containsElement = numbers.Contains(element);

        if (containsElement)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    else if (commandName == "PrintOdd")
    {
        foreach (int element in numbers)
        {
            if (element % 2 != 0)
            {
                Console.Write(element + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandName == "PrintEven")
    {
        foreach (int element in numbers)
        {
            if (element % 2 == 0)
            {

                Console.Write(element + " ");
            }
        }

        Console.WriteLine();

    }

    else if (commandName == "GetSum") //ready
    {
        int total = 0;
        foreach (int element in numbers)
        {
            total += element;
        }

        Console.WriteLine(total);
    }
    else if (commandName == "Filter")

    {
        string condition = commandParts[1].ToString();
        int number = int.Parse(commandParts[2]);

        foreach (int element in numbers)
        {
            bool conditionMet = false;
            switch (condition)
            {
                case ">":
                    conditionMet = element > number;
                    break;
                case ">=":
                    conditionMet = element >= number;
                    break;
                case "<":
                    conditionMet = element < number;
                    break;
                case "<=":
                    conditionMet = element <= number;
                    break;
                case "==":
                    conditionMet = element == number;
                    break;
            }

            if (conditionMet)
            {
                Console.Write(element + " ");
            }
        }
        Console.WriteLine();
    }

    command = Console.ReadLine();

}