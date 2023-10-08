namespace SimpleAndComplexCond;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        string type = "";

        switch (Math.Sign(number))
        {
            case -1:
                type = "negative";
                break;
            case 0:
                type = "zero";
                break;
            case 1:
                type = "positive";
                break;
        }


        Console.WriteLine(type);
    }
}

