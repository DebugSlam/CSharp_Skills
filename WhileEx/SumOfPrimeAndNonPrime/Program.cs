namespace SumOfPrimeAndNonPrime;
class Program
{
    static void Main(string[] args)
    {

        int NumberOfMovies = 0;

        int totalKidsTickets = 0;
        int totalStudentsTickets= 0;
        int totalStandardTickets = 0;


        while (true)

        {
            string movieName = Console.ReadLine();

            if (movieName == "Finish")
                break;

            int movieSize = int.Parse(Console.ReadLine());
            int movieSoldTickets = 0;

            while (movieSoldTickets < movieSize)

            {
                string ticketType = Console.ReadLine();
                if (ticketType == "End")
                    break;

                movieSoldTickets++;

                switch (ticketType)

                {
                    case "kid": totalKidsTickets++; break;
                    case "student": totalStudentsTickets++; break;
                    case "standard": totalStandardTickets++; break;

                }
            }

        Console.WriteLine($"{movieName} - {movieSoldTickets * 100.0 / movieSize:f2}% full.");


        }


        int totalTickets = totalStandardTickets + totalKidsTickets + totalStudentsTickets;

        Console.WriteLine($"Total tickets: {totalTickets}");

        Console.WriteLine($"{totalStudentsTickets * 100.0/totalTickets:f2}% student tickets.");
        Console.WriteLine($"{totalStandardTickets * 100.0 /totalTickets:f2}% standard tickets.");
        Console.WriteLine($"{totalKidsTickets * 100.0 / totalTickets:f2}% kids tickets.");

    }

}

