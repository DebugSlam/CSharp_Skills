namespace Vacation_Expenses;
class Program
{
    static void Main(string[] args)
    {
        string Season = Console.ReadLine();

        string accommodation = Console.ReadLine();

        int countOfDay = int.Parse(Console.ReadLine());

        double amount = 0.00;

        if (Season == "Spring")
        {
            if (accommodation == "Hotel")
            {
                amount = 30 * countOfDay * 0.8;
                
            }
            else if (accommodation == "Camping")
            {
                amount = 10 * countOfDay * 0.8;
                
            }


        }

        else if (Season == "Summer")
        {
            if (accommodation == "Hotel")
            {
                amount = 50 * countOfDay;
                
            }
            else if (accommodation == "Camping")
            {
                amount = 30 * countOfDay;
                
            }


        }

        else if (Season == "Autumn")
        {
            if (accommodation == "Hotel")
            {
                amount = 20 * countOfDay * 0.7;
                
            }
            else if (accommodation == "Camping")
            {
                amount = 15 * countOfDay * 0.7;
                
            }

        }

        else if (Season == "Winter")
        {
            if (accommodation == "Hotel")
            {
                amount = 40 * countOfDay * 0.9;
                
            }
            else if (accommodation == "Camping")
            {
                amount = 10 * countOfDay * 0.9;
                
            }


        }

        Console.WriteLine($"{amount:f2}");
    }
}

