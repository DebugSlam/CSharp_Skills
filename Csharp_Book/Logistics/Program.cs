using System;
class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int result1 = 0;
        int result2 = 0;
        int result3 = 0;


        for (int i = count; i > 0; i--)
        {

            int n = int.Parse(Console.ReadLine());


            if (n <= 3)
            { result1 += n; }

            if (n > 3 && n <= 11)
            { result2 += n; }


            if (n > 11)
            { result3 += n; }


        }

        int allTones = result1 + result2 + result3;

        double percent1 = (result1 * 100.0) / allTones;

        double percent2 = (result2 * 100.0) / allTones;

        double percent3 = (result3 * 100.0) / allTones;

        double AveragePrice = (result1 * 200.0 + result2 * 175.0 + result3 * 120.0) / allTones;

        Console.WriteLine($"{AveragePrice:f2}");
        Console.WriteLine($"{percent1:f2}%");
        Console.WriteLine($"{percent2:f2}%");
        Console.WriteLine($"{percent3:f2}%");
    }
}

