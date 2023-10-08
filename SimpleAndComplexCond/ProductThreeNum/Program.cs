namespace ProductThreeNum;
class Program
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());

        int n2 = int.Parse(Console.ReadLine());

        int n3 = int.Parse(Console.ReadLine());

        int sign = Math.Sign(n1 * n2 * n3);

        string result = "";

        switch (Math.Sign(sign))
        {
            case -1:
                result = "negative";
                break;
            case 0:
                result = "zero";
                break;
            case 1:
                result = "positive";
                break;

        }
        Console.WriteLine(result);
    }
}

