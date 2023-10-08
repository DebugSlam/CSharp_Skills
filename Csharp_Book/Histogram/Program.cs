namespace Histogram;
class Program
{
    static void Main(string[] args)
    {

        int count = int.Parse(Console.ReadLine());
        int result1 = 0;
        int result2 = 0;
        int result3 = 0;
        int result4 = 0;
        int result5 = 0;

        for (int i = count; i > 0; i--)
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 200)
            { result1 += 1; }

            if (n >= 200 && n < 400)
            { result2 += 1; }


            if (n >= 400 && n < 600)
            { result3 += 1; }


            if (n >= 600 && n < 800)
            { result4 += 1; }


            if (n >= 800)
            { result5 += 1; }


        }

        double percent1 = (result1 * 100.0) / count;

        double percent2 = (result2 * 100.0) / count;

        double percent3 = (result3 * 100.0) / count;

        double percent4 = (result4 * 100.0) / count;


        double percent5 = (result5 * 100.0) / count;


        Console.WriteLine($"{percent1:f2}%");
        Console.WriteLine($"{percent2:f2}%");
        Console.WriteLine($"{percent3:f2}%");
        Console.WriteLine($"{percent4:f2}%");
        Console.WriteLine($"{percent5:f2}%");
    }
}
