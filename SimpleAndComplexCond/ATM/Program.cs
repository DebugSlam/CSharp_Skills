namespace ATM;
class Program
{
    static void Main(string[] args)
    {
        int balance = int.Parse(Console.ReadLine());

        int withdraw = int.Parse(Console.ReadLine());

        int limit = int.Parse(Console.ReadLine());

        string type = "";
        if (limit < withdraw)
        {
            type = "The limit was exceeded.";

        }

        else if (balance < withdraw)
        {
            type = "Insufficient availability.";

        }

        else
        {
            type = "The withdraw was successful.";
        }

        Console.WriteLine(type);
    }
}