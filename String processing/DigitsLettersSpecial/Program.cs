string inputString = Console.ReadLine();

string numbers = "";
string letters = "";
string special= "";

for (int i = 0; i < inputString.Length; i++)
{

    if (char.IsDigit(inputString[i]))
    {
        numbers += inputString[i];

    }


    else if (char.IsLetter(inputString[i]))
    {
        letters += inputString[i];

    }


    else 
    {
        special += inputString[i];

    }
}

Console.WriteLine(numbers);

Console.WriteLine(letters);

Console.WriteLine(special);