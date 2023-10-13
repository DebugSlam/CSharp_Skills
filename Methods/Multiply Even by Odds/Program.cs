static int GetSumOfEven(int value)
{

    int sum = 0;


    while (value > 0)
    {
        int digit = value % 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }

        value /= 10;


    }

    return sum;
}


static int GetSumOfOdd(int value)
{
        int sum = 0;


        while (value > 0)
        {
            int digit = value % 10;

            if (digit % 2 != 0)
            {
                sum += digit;
            }

            value /= 10;

        }

    return sum;

}


int Number = int.Parse(Console.ReadLine());

int positivNumber = Math.Abs(Number);

int output = GetMultipleEvenOdds(positivNumber);

Console.WriteLine(output);



static int GetMultipleEvenOdds(int number)
    {
    int sumEven = GetSumOfEven(number);

    int sumOdd = GetSumOfOdd(number);

    int result = sumEven * sumOdd;
    return result;
}



