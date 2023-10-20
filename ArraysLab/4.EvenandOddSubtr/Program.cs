// See https://aka.ms/new-console-template for more information

string inputLine = Console.ReadLine();

string[] numberStrings = inputLine.Split(' ');

int[] array = new int[numberStrings.Length];


int sumOdd = 0;

int sumEve = 0;

for (int i = 0; i < numberStrings.Length; i++)
{
    if (int.TryParse(numberStrings[i], out int parsedNumber))
    {
        array[i] = parsedNumber;
    }
    else
    { }
}


for (int i = 0; i < array.Length; i++)


{

    if (array[i] % 2 == 0)
    {
        sumEve += array[i];
    }
    else
    {
        sumOdd += array[i];
    }
}

Console.WriteLine($"{sumEve - sumOdd}");

