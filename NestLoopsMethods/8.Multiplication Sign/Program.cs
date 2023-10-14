int num1 = int.Parse(Console.ReadLine());

int num2 = int.Parse(Console.ReadLine());

int num3 = int.Parse(Console.ReadLine());


string outT = NumberIs(num1, num2, num3); 

Console.WriteLine(outT);

static string NumberIs(int num1, int num2, int num3)
{
    string outText;
    if (num1 == 0 || num2 == 0 || num3 == 0)

    {
        outText = "zero";

    }

    else if ((num1 > 0 && num2 > 0 && num3 > 0) || (num1 < 0 && num2 < 0 && num3 > 0) ||
        (num1 < 0 && num2 > 0 && num3 < 0) || (num1 > 0 && num2 < 0 && num3 < 0))

    {
        outText = "positive";

    }

    else

    {
        outText = "negative";

    }

    return outText;
}