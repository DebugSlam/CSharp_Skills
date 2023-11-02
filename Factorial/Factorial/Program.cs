int num1 = int.Parse(Console.ReadLine());

Console.WriteLine(FactorelNum(num1));

static int FactorelNum(int n1)
{
    int sumDigit = 1;
    int Amount = 0;
    int digit = 0;

    while (n1>0)
    {
        digit = n1 % 10;
        n1 = n1 / 10;

        if (digit % 2 == 0)
        {
            for (int i = 1; i <= digit; i++)
            {
                sumDigit *= i;
            }
            Amount += sumDigit;
        }

        sumDigit = 1;
    }
    return Amount;
}