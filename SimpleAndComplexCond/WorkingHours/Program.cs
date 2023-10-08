namespace WorkingHours;
class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());

        string day = Console.ReadLine();

        if (hours >= 10 && hours <= 18 && day != "Saturday")


        { Console.WriteLine("open"); }

        else
        { Console.WriteLine("closed"); }
    }
}

