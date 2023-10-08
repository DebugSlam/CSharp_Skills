namespace InvalidNumber;
class Program
{
    static void Main(string[] args)
    {
        int sec1 = int.Parse(Console.ReadLine());

        int sec2 = int.Parse(Console.ReadLine());

        int sec3 = int.Parse(Console.ReadLine());

        int sumSec = sec1 + sec2 + sec3;

        int minutes = sumSec / 60;

        int Seconds = sumSec % 60;

            Console.WriteLine($"{minutes}:{Seconds:d2}");
    }
}

