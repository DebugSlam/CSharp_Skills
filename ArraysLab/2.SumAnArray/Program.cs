// See https://aka.ms/new-console-template for more information

string inputLine = Console.ReadLine();

string[] numberStrings = inputLine.Split(' ');

int[] array = new int[numberStrings.Length];




int sum = 0;

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

    sum += array[i];
}

Console.WriteLine($"{sum}");

