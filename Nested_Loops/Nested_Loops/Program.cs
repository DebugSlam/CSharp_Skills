namespace Nested_Loops;
class Program
{

    static void Main()
    {

        int startRange = int.Parse(Console.ReadLine());
        int EndRange = int.Parse(Console.ReadLine());

        


        for (int c = startRange; c <= EndRange; c++)
        {
            bool isPrime = true;
            int countPrime = 0;
            for (int div = 1; div <= c; div++)
            {
                
                if (c % div == 0)

                {
                    countPrime++;
                }

                if (countPrime > 2)
                { isPrime = false; break; }
            }
            if (isPrime)
            { Console.Write(c + " "); }
            countPrime = 0;

        }
        Console.WriteLine();
    }
}



