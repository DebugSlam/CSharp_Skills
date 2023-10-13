
static int MathPower(int basen, int power)
{
    double result = Math.Pow(basen, power);
    int intResult = (int)result;
    return intResult;
}



int baseNum = int.Parse(Console.ReadLine());

int powerNum = int.Parse(Console.ReadLine());

int Result = MathPower(baseNum, powerNum);

Console.WriteLine(Result);