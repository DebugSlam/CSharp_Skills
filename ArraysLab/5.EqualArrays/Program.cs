int[] array1 = InputToArray();

int[] array2 = InputToArray();

bool identical = true;

for (int i1 = 0; i1 < array1.Length; i1++)
{

    for (int i2 = 0; i2 < array2.Length; i2++)
    {
        if (array1[i1] == array2[i2])

        {
            Console.Write($"{array1[i1]} ");

        }
        else
        {

        }

    }

}

Console.WriteLine();

static int[] InputToArray()
    {
        string inputLine = Console.ReadLine();

        string[] numberStrings = inputLine.Split(' ');

        int[] array = new int[numberStrings.Length];

        for (int i = 0; i < numberStrings.Length; i++)
        {
            if (int.TryParse(numberStrings[i], out int parsedNumber))
            {
                array[i] = parsedNumber;
            }
            else
            { }

        }
        return array;
    }