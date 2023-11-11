string[] searchBannedCommands = Console.ReadLine().Split(", ");



string inputString = Console.ReadLine();

string output = "";

for (int i = 0; i < searchBannedCommands.Length; i++)
{

    string currentWord = searchBannedCommands[i];

    string replacement = new string('*', currentWord.Length);

    while (inputString.IndexOf(currentWord) >= 0)
    {

        output = inputString.Replace(currentWord, replacement);
        inputString = output;

    }

}

Console.WriteLine(output);
