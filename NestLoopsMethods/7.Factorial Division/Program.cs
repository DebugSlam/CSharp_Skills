int num1 = int.Parse(Console.ReadLine());

int num2 = int.Parse(Console.ReadLine());




Console.WriteLine(CalculateFactorialDivision(num1, num2));

static long FactorelNum(int n1)
{
    long sum = 1;
    for (int i = 1; i <= n1; i++)
    {
        sum *= i;

    }
    return sum;
}

static long CalculateFactorialDivision(int num1, int num2)
{
    long result = FactorelNum(num1) / FactorelNum(num2);

    return result;
}